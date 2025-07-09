using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TSL.Data.Models.ERPXL_TSL;

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
                string msg = args.Length > 1 ? string.Join(" ", args.Skip(1)) : "";
                MessageSender.ShowPopup(msg);
                return;
            }
            try
            {
                var config = LoadConfig("config.xml");
                if (config == null) return;

                var connStr = "Server=TSLCOMARCHDB;Database=ERPXL_TSL;User Id=sa_tsl;Password=@nalizyGrudzien24@;TrustServerCertificate=True;";
                var userGroups = LoadUserGroups("UserGroups.json");
                var groupModuleLimits = LoadGroupModuleLimits("GroupModuleLimits.json");
                var moduleLimits = LoadModuleLimits("ModuleLimits.json");
                var linkedModulesMap = LoadLinkedModules("LinkedModules.json");

                var options = new DbContextOptionsBuilder<ERPXL_TSLContext>()
                    .UseSqlServer(connStr)
                    .Options;

                using var context = new ERPXL_TSLContext(options);

                List<SessionInfo> sessions;
                try
                {
                    sessions = context.Sesjes
                       .Where(s => s.SesStop == 0 && s.SesAdospid != null)
                       .Select(s => new SessionInfo
                       {
                           Spid = (int)s.SesAdospid.Value,
                           UserName = s.SesOpeIdent,
                           Module = s.SesModul,
                           Start = (long)(s.SesStart ?? 0)
                       })
                       .ToList();
                    Log("INFO", $"Found {sessions.Count} active sessions.");
                }
                catch (Exception ex)
                {
                    Log("ERROR", $"Failed to read sessions: {ex.Message}");
                    return;
                }

                if (sessions.Count <= config.ActiveUsersCheck)
                {
                    Log("INFO", $"Active sessions ({sessions.Count}) ≤ threshold ({config.ActiveUsersCheck}). Skip processing.");
                    return;
                }

                var now = DateTime.Now;
                var currentHour = now.Hour;

                var sessionsByModule = sessions.GroupBy(s => s.Module);

                foreach (var mod in sessionsByModule)
                {
                    try
                    {
                        if (!moduleLimits.TryGetValue(mod.Key ?? string.Empty, out var max))
                        {
                            Log("INFO", $"[Module: {mod.Key}] — no limit, skip.");
                            continue;
                        }

                        var active = mod.OrderBy(s => s.Start)
                                         .Where(s => !ExceptionUsers.Contains(s.UserName))
                                         .ToList();

                        if (active.Count > max)
                        {
                            var toTerminate = active.Skip(max).ToList();
                            foreach (var s in toTerminate)
                            {
                                MessageSender.Send(s.UserName, "License limit reached. Session will be closed.");
                                KillSession(s.Spid, s.UserName, context, "ModuleLimit", s, null, max, active);
                                sessions.RemoveAll(x => x.Spid == s.Spid);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log("ERROR", $"Exception during module limit check for {mod.Key}: {ex.Message}");
                    }
                }

                var sessionsByGroupModule = sessions
                    .Where(s => userGroups.ContainsKey(s.UserName))
                    .Select(s => new { Session = s, Group = userGroups[s.UserName] })
                    .GroupBy(x => (x.Group, x.Session.Module));

                foreach (var gm in sessionsByGroupModule)
                {
                    try
                    {
                        var module = gm.Key.Module ?? string.Empty;
                        var group = gm.Key.Group;
                        var key = (group, module, currentHour);

                        int max;

                        if (!groupModuleLimits.TryGetValue(key, out max))
                        {
                            string matchedLinkedKey = linkedModulesMap
                                .FirstOrDefault(kv => kv.Value.Contains(module)).Key;

                            if (!string.IsNullOrEmpty(matchedLinkedKey))
                            {
                                var linkedKey = (group, matchedLinkedKey, currentHour);
                                if (!groupModuleLimits.TryGetValue(linkedKey, out max))
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

                        var ordered = gm.OrderBy(x => x.Session.Start)
                                        .Select(x => x.Session)
                                        .Where(s => !ExceptionUsers.Contains(s.UserName))
                                        .ToList();

                        if (ordered.Count > max)
                        {
                            var toKill = ordered.Skip(max).ToList();
                            foreach (var s in toKill)
                            {
                                MessageSender.Send(s.UserName, "License limit reached. Session will be closed.");
                                KillSession(s.Spid, s.UserName, context, "ModuleGroupLimit", s, group, max, ordered);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        Log("ERROR", $"Exception during group/module limit check: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Log("ERROR", $"Critical error in Main: {ex.Message}");
            }
        }

        static AppConfig LoadConfig(string path)
        {
            try
            {
                var config = AppConfig.Load(path);
                Log("INFO", $"Loaded config. ActiveUsersCheck = {config.ActiveUsersCheck}");
                return config;
            }
            catch (Exception ex)
            {
                Log("ERROR", $"Failed to load config: {ex.Message}");
                return null;
            }
        }

        static Dictionary<string, string> LoadUserGroups(string path)
        {
            try
            {
                if (!File.Exists(path)) return new();
                var json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }
            catch (Exception ex)
            {
                Log("ERROR", $"Failed to load {path}: {ex.Message}");
                return new();
            }
        }

        static Dictionary<(string Group, string Module, int Hour), int> LoadGroupModuleLimits(string path)
        {
            try
            {
                if (!File.Exists(path)) return new();
                var json = File.ReadAllText(path);
                var list = JsonConvert.DeserializeObject<List<GroupModuleLimit>>(json);
                return list.ToDictionary(x => (x.GroupCode, x.Module, x.Hour), x => x.MaxLicenses);
            }
            catch (Exception ex)
            {
                Log("ERROR", $"Failed to load {path}: {ex.Message}");
                return new();
            }
        }

        static Dictionary<string, int> LoadModuleLimits(string path)
        {
            try
            {
                if (!File.Exists(path)) return new();
                var json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
            }
            catch (Exception ex)
            {
                Log("ERROR", $"Failed to load {path}: {ex.Message}");
                return new();
            }
        }

        static Dictionary<string, List<string>> LoadLinkedModules(string path)
        {
            try
            {
                if (!File.Exists(path)) return new();
                var json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json);
            }
            catch (Exception ex)
            {
                Log("ERROR", $"Failed to load {path}: {ex.Message}");
                return new();
            }
        }

        static void KillSession(
            int spid,
            string user,
            ERPXL_TSLContext context,
            string reason,
            SessionInfo session = null,
            string group = null,
            int? max = null,
            List<SessionInfo> related = null)
        {
            try
            {
                EndSession(spid, context);
                context.Database.ExecuteSqlRaw($"KILL {spid}");
                LogKill(user, spid, reason, session, group, max, related);
                Log("INFO", $"KILL {spid} ({reason})");
            }
            catch (Exception ex)
            {
                Log("ERROR", $"Ошибка KILL {spid}: {ex.Message}");
            }
        }

        static void EndSession(int spid, ERPXL_TSLContext context)
        {
            try
            {
                var ses = context.Sesjes.FirstOrDefault(s => s.SesAdospid == spid && s.SesStop == 0);
                if (ses != null)
                {
                    ses.SesStop = (int)DateTimeOffset.Now.ToUnixTimeSeconds();
                    ses.SesAktywna = 0;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Log("ERROR", $"Ошибка EndSession {spid}: {ex.Message}");
            }
        }

        static void LogKill(
           string user,
           int spid,
           string reason,
           SessionInfo session = null,
           string group = null,
           int? max = null,
           List<SessionInfo> related = null)
            {
                var log = new StringBuilder();

                log.Append($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] KILL {spid} USER={user}");

                if (session != null)
                    log.Append($" MODULE={session.Module} START={session.Start}");

                if (!string.IsNullOrEmpty(group))
                    log.Append($" GROUP={group}");

                if (max.HasValue)
                    log.Append($" MAX={max.Value}");

                log.Append($" REASON={reason}");

                File.AppendAllText("kill_log.txt", log.ToString() + Environment.NewLine, Encoding.UTF8);

                if (related != null && related.Count > 0)
                {
                    var json = JsonConvert.SerializeObject(related.Select(x => new
                    {
                        x.UserName,
                        x.Module,
                        x.Start
                    }), Formatting.Indented);

                    File.AppendAllText("kill_log.txt", json + Environment.NewLine + Environment.NewLine, Encoding.UTF8);
                }
            }

        static void Log(string status, string message)
        {
            var logLine = $"[{status}][{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            File.AppendAllText("process_log.txt", logLine + Environment.NewLine, Encoding.UTF8);
        }

        class GroupModuleLimit
        {
            public string GroupCode { get; set; }
            public string Module { get; set; }
            public int Hour { get; set; }
            public int MaxLicenses { get; set; }
        }

        class SessionInfo
        {
            public int Spid { get; set; }
            public string UserName { get; set; }
            public string Module { get; set; }
            public long Start { get; set; }
        }
    }
}
