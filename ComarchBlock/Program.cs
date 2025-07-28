using ComarchBlock.dto;
using ComarchBlock.utils;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text;
using TSL.Data.Models.ERPXL_TSL;
using static ComarchBlock.utils.SessionManager;
using static ComarchBlock.utils.PendingKillManager;

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
            if (args.Length > 0 && args[0] == "--popup")
            {
                MessageSender.ShowPopup(string.Join(" ", args.Skip(1)));
                return;
            }

            var init = new AppInitializer();
            if (!init.Initialize()) return;

            var config = init.Config!;
            var userGroups = init.UserGroups;
            var groupModuleLimits = init.GroupModuleLimits;
            var moduleLimits = init.ModuleLimits;
            var linkedModulesMap = init.LinkedModules;
            using var context = init.DbContext!;

            Load();
            ProcessDueKills(context);

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

            foreach (var modGroup in sessions.GroupBy(s => s.Module ?? string.Empty))
            {
                if (moduleLimits.TryGetValue(modGroup.Key, out var max))
                {
                    EnforceLimit(modGroup, max, context, userGroups, "ModuleLimit");
                    sessions.RemoveAll(s => !modGroup.Any(x => x.Spid == s.Spid));
                }
                else
                {
                    Log("INFO", $"[Module: {modGroup.Key}] — no limit, skip.");
                }
            }

            var groupModuleSessions = sessions
                .Where(s => userGroups.ContainsKey(s.UserName))
                .Select(s => new { s, Entry = userGroups[s.UserName] })
                .GroupBy(x => (x.Entry.Group, x.s.Module ?? string.Empty));

            foreach (var g in groupModuleSessions)
            {
                var (group, module) = g.Key;
                var key = (group, module, currentHour);

                if (!groupModuleLimits.TryGetValue(key, out var max))
                {
                    string? linkedKey = linkedModulesMap
                        .FirstOrDefault(kv => kv.Value.Contains(module)).Key;

                    if (!string.IsNullOrEmpty(linkedKey))
                    {
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
        }

        static void EnforceLimit(
            IEnumerable<SessionInfo> sessions,
            int max,
            ERPXL_TSLContext context,
            Dictionary<string, UserGroupEntry> userGroups,
            string reason,
            string? group = null)
        {
            var ordered = sessions
                .OrderBy(s => s.Start)
                .Where(s => !ExceptionUsers.Contains(s.UserName))
                .ToList();

            if (ordered.Count <= max) return;

            var toKill = ordered.Skip(max).ToList();

            foreach (var s in toKill)
            {
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
            }
        }
        static bool IsSpidActive(int spid)
        {
            try
            {
                var process = System.Diagnostics.Process.GetProcessById(spid);
                return !process.HasExited;
            }
            catch
            {
                return false;
            }
        }

    }
}



