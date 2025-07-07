using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class PendingChange
{
    public int PcId { get; set; }

    public int PcUser { get; set; }

    public int PcChangedObjId { get; set; }

    public string PcChangedObjTable { get; set; } = null!;

    public string PcOtOperation { get; set; } = null!;

    public string? PcPropertyName { get; set; }

    public string? PcPropertyOldVal { get; set; }

    public string? PcPropertyNewVal { get; set; }

    public DateTime PcModificationTime { get; set; }

    public virtual OperationType PcOtOperationNavigation { get; set; } = null!;
}
