using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class ProfilerEntry
{
    public int PenId { get; set; }

    public int PenEventClass { get; set; }

    public bool PenBegin { get; set; }

    public int PenLevel { get; set; }

    public string? PenSessionId { get; set; }

    public string PenConnectionId { get; set; } = null!;

    public string? PenClientIp { get; set; }

    public string? PenApplicationName { get; set; }

    public string? PenUsername { get; set; }

    public string? PenPassword { get; set; }

    public string? PenLanguage { get; set; }

    public DateTime? PenBeginTime { get; set; }

    public DateTime? PenEndTime { get; set; }

    public string? PenModel { get; set; }

    public string? PenMessage { get; set; }

    public virtual ICollection<ProfilerEntriesProperty> ProfilerEntriesProperties { get; set; } = new List<ProfilerEntriesProperty>();
}
