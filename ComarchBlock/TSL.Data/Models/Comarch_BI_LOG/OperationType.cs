using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class OperationType
{
    public string OtOperation { get; set; } = null!;

    public virtual ICollection<PendingChange> PendingChanges { get; set; } = new List<PendingChange>();
}
