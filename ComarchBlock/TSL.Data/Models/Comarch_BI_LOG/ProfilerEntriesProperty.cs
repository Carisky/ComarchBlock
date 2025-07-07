using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class ProfilerEntriesProperty
{
    public int PepId { get; set; }

    public int PepEntryId { get; set; }

    public string PepName { get; set; } = null!;

    public string PepValue { get; set; } = null!;

    public virtual ProfilerEntry PepEntry { get; set; } = null!;
}
