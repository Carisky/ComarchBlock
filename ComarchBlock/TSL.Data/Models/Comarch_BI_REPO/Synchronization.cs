using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Synchronization
{
    public byte[] SnhLastSynchroTs { get; set; } = null!;

    public DateTime? SnhLastSynchroDateTime { get; set; }

    public int? SnhType { get; set; }
}
