
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TSL.Data.Models.ERPXL_TSL;
namespace ComarchBlock
{
    internal class Program
    {
        static readonly HashSet<string> ExceptionUsers = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "ADMIN"
        };

        static void Main()
        {
            var config = AppConfig.Load("config.xml");
            Console.WriteLine($"Config: ActiveUsersCheck = {config.ActiveUsersCheck}");


            var connStr = "Server=TSLCOMARCHDB;Database=ERPXL_TSL;User Id=sa_tsl;Password=@nalizyGrudzien24@;TrustServerCertificate=True;";

            var userGroups = LoadUserGroups("UserGroups.json");
            var groupModuleLimits = LoadGroupModuleLimits("GroupModuleLimits.json");
            var moduleLimits = LoadModuleLimits("ModuleLimits.json");

            Console.WriteLine("Loaded Users + Groups:");
            foreach (var kv in userGroups)
                Console.WriteLine($"  User: {kv.Key} → Group: {kv.Value}");

            Console.WriteLine("\nLoaded Group Module Limits:");
            foreach (var kv in groupModuleLimits)
                Console.WriteLine($"  Group: {kv.Key.Group}, Module: {kv.Key.Module}, Hour: {kv.Key.Hour} → Limit: {kv.Value}");

            Console.WriteLine("\nLoaded Module Limits:");
            foreach (var kv in moduleLimits)
                Console.WriteLine($"  Module: {kv.Key} → Limit: {kv.Value}");

            var options = new DbContextOptionsBuilder<ERPXL_TSLContext>()
                .UseSqlServer(connStr)
                .Options;

            using (var context = new ERPXL_TSLContext(options))
            {
                var now = DateTime.Now;
                var currentHour = now.Hour;

                var sessions = context.Sesjes
                   .Where(s => s.SesStop == 0 && s.SesAdospid != null)
                   .Select(s => new SessionInfo
                   {
                       Spid = (int)s.SesAdospid.Value,
                       UserName = s.SesOpeIdent,
                       Module = s.SesModul,
                       Start = (long)(s.SesStart ?? 0)
                   })
                   .ToList();


                Console.WriteLine($"\nFound {sessions.Count} active sessions.");

                if (sessions.Count <= config.ActiveUsersCheck)
                {
                    Console.WriteLine($"Active sessions ({sessions.Count}) ≤ threshold ({config.ActiveUsersCheck}). Skip processing.");
                    return;
                }

                // enforce module based limits first
                var sessionsByModule = sessions.GroupBy(s => s.Module);

                foreach (var mod in sessionsByModule)
                {
                    if (!moduleLimits.TryGetValue(mod.Key ?? string.Empty, out var max))
                    {
                        Console.WriteLine($"\n[Module: {mod.Key}] — no limit, skip.");
                        continue;
                    }

                    var active = mod.OrderBy(s => s.Start)
                                     .Where(s => !ExceptionUsers.Contains(s.UserName))
                                     .ToList();

                    Console.WriteLine($"\n[Module: {mod.Key}] Users: {active.Count}, limit: {max}");

                    if (active.Count > max)
                    {
                        var toTerminate = active.Skip(max).ToList();
                        Console.WriteLine($"  Over limit. Will terminate {toTerminate.Count} sessions:");
                        foreach (var s in toTerminate)
                        {
                            Console.WriteLine($"    - User: {s.UserName}, SPID: {s.Spid}, Start: {s.Start}");
                            KillSession(s.Spid, s.UserName, context, "ModuleLimit");
                            sessions.RemoveAll(x => x.Spid == s.Spid);
                        }
                    }
                }

                var sessionsByGroupModule = sessions
                    .Where(s => userGroups.ContainsKey(s.UserName))
                    .Select(s => new { Session = s, Group = userGroups[s.UserName] })
                    .GroupBy(x => (x.Group, x.Session.Module));

                foreach (var gm in sessionsByGroupModule)
                {
                    var key = (gm.Key.Group, gm.Key.Module ?? string.Empty, currentHour);
                    int max;
                    if (!groupModuleLimits.TryGetValue(key, out max))
                    {
                        if (!moduleLimits.TryGetValue(gm.Key.Module ?? string.Empty, out max))
                        {
                            Console.WriteLine($"\n[Group: {gm.Key.Group}, Module: {gm.Key.Module}] — no limit, skip.");
                            continue;
                        }
                    }

                    var ordered = gm.OrderBy(x => x.Session.Start)
                                    .Select(x => x.Session)
                                    .Where(s => !ExceptionUsers.Contains(s.UserName))
                                    .ToList();

                    Console.WriteLine($"\n[Group: {gm.Key.Group}] Module: {gm.Key.Module} → {ordered.Count} sessions, limit {max}");

                    if (ordered.Count > max)
                    {
                        var toKill = ordered.Skip(max).ToList();
                        foreach (var s in toKill)
                        {
                            Console.WriteLine($"    - User: {s.UserName}, SPID: {s.Spid}, Start: {s.Start}");
                            KillSession(s.Spid, s.UserName, context, "ModuleGroupLimit");
                        }
                    }
                }
            }
        }



        static Dictionary<string, string> LoadUserGroups(string path)
        {
            if (!File.Exists(path)) return new Dictionary<string, string>();
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }

        static Dictionary<(string Group, string Module, int Hour), int> LoadGroupModuleLimits(string path)
        {
            if (!File.Exists(path)) return new Dictionary<(string, string, int), int>();
            var json = File.ReadAllText(path);
            var list = JsonConvert.DeserializeObject<List<GroupModuleLimit>>(json);
            return list.ToDictionary(x => (x.GroupCode, x.Module, x.Hour), x => x.MaxLicenses);
        }

        static Dictionary<string, int> LoadModuleLimits(string path)
        {
            if (!File.Exists(path)) return new Dictionary<string, int>();
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
        }

        static void KillSession(int spid, string user, ERPXL_TSLContext context, string reason)
        {
            try
            {
                context.Database.ExecuteSqlRaw($"KILL {spid}");
                LogKill(user, spid, reason);
                Console.WriteLine($"KILL {spid} ({reason})");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка KILL {spid}: {ex.Message}");
            }
        }

        static void LogKill(string user, int spid, string reason)
        {
            var log = $"[{DateTime.Now}] KILL {spid} USER={user} REASON={reason}";
            File.AppendAllText("kill_log.txt", log + Environment.NewLine);
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

