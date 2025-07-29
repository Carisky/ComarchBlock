using ComarchBlock.dto;
using ComarchBlock.utils;
using ComarchBlock.entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text;
using TSL.Data.Models.ERPXL_TSL;
using static ComarchBlock.utils.SessionManager;
using static ComarchBlock.utils.PendingKillManager;

// ... using directives остаются без изменений

namespace ComarchBlock
{
    internal class Program
    {
        static readonly HashSet<string> ExceptionUsers = new(StringComparer.OrdinalIgnoreCase)
        {
            "ADMIN","Zarząd","Biuro Księgowe","TSL SILESIA SP. Z O.O."
        };

        static void Main(string[] args)
        {
            try
            {
                Log("DEBUG", "=== Application started ===");

                if (args.Length > 0 && args[0] == "--popup")
                {
                    Log("DEBUG", "Popup argument detected.");
                    MessageSender.ShowPopup(string.Join(" ", args.Skip(1)));
                    return;
                }

                Log("DEBUG", "Initializing application...");
                var init = new AppInitializer();
                if (!init.Initialize())
                {
                    Log("ERROR", "Initialization failed.");
                    return;
                }

                Log("DEBUG", "Initialization successful.");
                var config = init.Config!;
                var userGroups = init.UserGroups;
                var groupModuleLimits = init.GroupModuleLimits;
                var moduleLimits = init.ModuleLimits;
                var linkedModulesMap = init.LinkedModules;

                Log("DEBUG", $"Loaded config: {JsonConvert.SerializeObject(config)}");
                Log("DEBUG", $"UserGroups count: {userGroups.Count}");
                Log("DEBUG", $"GroupModuleLimits count: {groupModuleLimits.Count}");
                Log("DEBUG", $"ModuleLimits count: {moduleLimits.Count}");
                Log("DEBUG", $"LinkedModulesMap count: {linkedModulesMap.Count}");

                using var context = init.DbContext!;
                Log("DEBUG", "Loading pending kills...");
                Load();
                Log("DEBUG", "Processing due kills...");
                ProcessDueKills(context);

                Log("DEBUG", "Fetching active sessions...");
                var sessions = context.Sesjes
                    .Where(s => s.SesStop == 0 && s.SesAdospid != null)
                    .Select(s => new SessionInfo
                    {
                        Spid = (int)s.SesAdospid,
                        UserName = s.SesOpeIdent,
                        Module = s.SesModul,
                        Start = (long)(s.SesStart ?? 0)
                    })
                    .ToList();

                Log("INFO", $"Found {sessions.Count} active sessions.");

                if (sessions.Count <= config.ActiveUsersCheck)
                {
                    Log("INFO", $"Active sessions ({sessions.Count}) ≤ threshold ({config.ActiveUsersCheck}). Skip processing.");
                    return;
                }

                var now = DateTime.Now;
                var currentHour = now.Hour;

                Log("DEBUG", "Checking module limits...");
                foreach (var modGroup in sessions.GroupBy(s => s.Module ?? string.Empty))
                {
                    Log("DEBUG", $"Processing module: {modGroup.Key}");

                    if (moduleLimits.TryGetValue(modGroup.Key, out var max))
                    {
                        Log("DEBUG", $"Enforcing module limit: {max} for {modGroup.Key}");
                        EnforceLimit(modGroup, max, context, userGroups, "ModuleLimit");
                        sessions.RemoveAll(s => !modGroup.Any(x => x.Spid == s.Spid));
                    }
                    else
                    {
                        Log("INFO", $"[Module: {modGroup.Key}] — no limit, skip.");
                    }
                }

                Log("DEBUG", "Checking group-module limits...");
                var groupModuleSessions = sessions
                    .Where(s => userGroups.ContainsKey(s.UserName))
                    .Select(s => new { s, Entry = userGroups[s.UserName] })
                    .GroupBy(x => (x.Entry.Group, x.s.Module ?? string.Empty));

                foreach (var g in groupModuleSessions)
                {
                    var (group, module) = g.Key;
                    var key = (group, module, currentHour);
                    Log("DEBUG", $"Checking limit for Group: {group}, Module: {module}, Hour: {currentHour}");

                    if (!groupModuleLimits.TryGetValue(key, out var max))
                    {
                        string? linkedKey = linkedModulesMap
                            .FirstOrDefault(kv => kv.Value.Contains(module)).Key;

                        if (!string.IsNullOrEmpty(linkedKey))
                        {
                            Log("DEBUG", $"Fallback to linked module: {linkedKey}");
                            var fallbackKey = (group, linkedKey, currentHour);
                            if (!groupModuleLimits.TryGetValue(fallbackKey, out max))
                            {
                                if (!moduleLimits.TryGetValue(module, out max))
                                {
                                    Log("INFO", $"[Group: {group}, Module: {module}] — no limit, skip.");
                                    continue;
                                }
                            }
                        }
                        else if (!moduleLimits.TryGetValue(module, out max))
                        {
                            Log("INFO", $"[Group: {group}, Module: {module}] — no limit, skip.");
                            continue;
                        }
                    }

                    var ordered = g.Select(x => x.s).OrderBy(x => x.Start).Where(x => !ExceptionUsers.Contains(x.UserName));
                    EnforceLimit(ordered, max, context, userGroups, "ModuleGroupLimit", group);
                }

                Log("DEBUG", "=== Application finished successfully ===");
            }
            catch (Exception ex)
            {
                Log("ERROR", $"Unhandled exception: {ex}");
            }
        }

        static void EnforceLimit(
            IEnumerable<SessionInfo> sessions,
            int max,
            ERPXL_TSLContext context,
            Dictionary<string, DbUserGroup> userGroups,
            string reason,
            string? group = null)
        {
            var ordered = sessions
                .OrderBy(s => s.Start)
                .Where(s => !ExceptionUsers.Contains(s.UserName))
                .ToList();

            Log("DEBUG", $"Enforcing limit. Max allowed: {max}, current: {ordered.Count}");

            if (ordered.Count <= max) return;

            var toKill = ordered.Skip(max).ToList();
            Log("DEBUG", $"Need to kill {toKill.Count} session(s).");

            foreach (var s in toKill)
            {
                Log("DEBUG", $"Processing session: {JsonConvert.SerializeObject(s)}");

                if (!userGroups.TryGetValue(s.UserName, out var entry))
                {
                    Log("INFO", $"User {s.UserName} not found in userGroups. Skipping.");
                    continue;
                }

                if (string.IsNullOrWhiteSpace(entry.WindowsUser))
                {
                    Log("INFO", $"User {s.UserName} has no WindowsUser. Skipping.");
                    continue;
                }

                if (!IsSpidActive(s.Spid))
                {
                    Log("INFO", $"SPID {s.Spid} not active for user {s.UserName}. Skipping.");
                    continue;
                }

                if (Get(s.Spid) == null)
                {
                    Log("DEBUG", $"Sending warning to user {entry.WindowsUser}.");
                    MessageSender.Send(entry.WindowsUser, "Limit licencji został przekroczony. Sesja zostanie zamknięta za 5 minut.");
                    Add(new PendingKillEntry
                    {
                        Spid = s.Spid,
                        UserName = s.UserName,
                        Module = s.Module,
                        Start = s.Start,
                        Reason = reason,
                        Group = group,
                        Max = max,
                        KillTime = DateTime.Now.AddMinutes(5)
                    });
                }
                else
                {
                    Log("DEBUG", $"Session {s.Spid} already scheduled for kill.");
                }
            }
        }

        static bool IsSpidActive(int spid)
        {
            try
            {
                var process = System.Diagnostics.Process.GetProcessById(spid);
                return !process.HasExited;
            }
            catch (Exception ex)
            {
                Log("WARN", $"SPID {spid} not found: {ex.Message}");
                return false;
            }
        }
    }
}



