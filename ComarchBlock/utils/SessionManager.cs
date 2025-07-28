using System.Text;
using ComarchBlock.dto;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TSL.Data.Models.ERPXL_TSL;
namespace ComarchBlock.utils
{
    public static class SessionManager
    {
        private static readonly string KillLogPath = "kill_log.txt";
        private static readonly string ProcessLogPath = "process_log.txt";

        public static void KillSession(
            int spid,
            string user,
            ERPXL_TSLContext context,
            string reason,
            SessionInfo? session = null,
            string? group = null,
            int? max = null,
            List<SessionInfo>? related = null)
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

        public static void EndSession(int spid, ERPXL_TSLContext context)
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

        public static void LogKill(
            string user,
            int spid,
            string reason,
            SessionInfo? session = null,
            string? group = null,
            int? max = null,
            List<SessionInfo>? related = null)
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

            File.AppendAllText(KillLogPath, log.ToString() + Environment.NewLine, Encoding.UTF8);

            if (related != null && related.Count > 0)
            {
                var json = JsonConvert.SerializeObject(
                    related.Select(x => new { x.UserName, x.Module, x.Start }),
                    Formatting.Indented
                );

                File.AppendAllText(KillLogPath, json + Environment.NewLine + Environment.NewLine, Encoding.UTF8);
            }
        }

        public static void Log(string status, string message)
        {
            var logLine = $"[{status}][{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            File.AppendAllText(ProcessLogPath, logLine + Environment.NewLine, Encoding.UTF8);
        }
        public static bool IsSpidActive(int spid)
        {
            try
            {
                using var process = System.Diagnostics.Process.GetProcessById(spid);
                return !process.HasExited;
            }
            catch
            {
                return false;
            }
        }

    }
}
