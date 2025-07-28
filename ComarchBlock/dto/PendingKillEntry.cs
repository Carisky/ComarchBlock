namespace ComarchBlock.dto
{
    public class PendingKillEntry
    {
        public int Spid { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Module { get; set; } = string.Empty;
        public long Start { get; set; }
        public string Reason { get; set; } = string.Empty;
        public string? Group { get; set; }
        public int? Max { get; set; }
        public DateTime KillTime { get; set; }
    }
}
