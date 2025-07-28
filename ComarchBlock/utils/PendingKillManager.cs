using ComarchBlock.dto;
using Newtonsoft.Json;
using TSL.Data.Models.ERPXL_TSL;

namespace ComarchBlock.utils
{
    public static class PendingKillManager
    {
        private static readonly string PendingFilePath = "pending_kills.json";
        private static List<PendingKillEntry> _entries = new();

        public static void Load()
        {
            try
            {
                if (File.Exists(PendingFilePath))
                {
                    var json = File.ReadAllText(PendingFilePath);
                    _entries = JsonConvert.DeserializeObject<List<PendingKillEntry>>(json)
                        ?? new List<PendingKillEntry>();
                }
            }
            catch
            {
                _entries = new List<PendingKillEntry>();
            }
        }

        public static void Save()
        {
            try
            {
                var json = JsonConvert.SerializeObject(_entries, Formatting.Indented);
                File.WriteAllText(PendingFilePath, json);
            }
            catch { }
        }

        public static PendingKillEntry? Get(int spid)
            => _entries.FirstOrDefault(e => e.Spid == spid);

        public static void Add(PendingKillEntry entry)
        {
            _entries.Add(entry);
            Save();
        }

        public static void Remove(PendingKillEntry entry)
        {
            _entries.Remove(entry);
            Save();
        }

        public static void ProcessDueKills(ERPXL_TSLContext context)
        {
            var now = DateTime.Now;
            foreach (var entry in _entries.ToList())
            {
                if (entry.KillTime <= now)
                {
                    if (SessionManager.IsSpidActive(entry.Spid))
                    {
                        var info = new SessionInfo
                        {
                            Spid = entry.Spid,
                            UserName = entry.UserName,
                            Module = entry.Module,
                            Start = entry.Start
                        };
                        SessionManager.KillSession(entry.Spid, entry.UserName, context, entry.Reason, info, entry.Group, entry.Max);
                    }
                    Remove(entry);
                }
            }
        }
    }
}
