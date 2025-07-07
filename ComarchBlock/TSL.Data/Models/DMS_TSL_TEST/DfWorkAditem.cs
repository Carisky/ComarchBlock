using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkAditem
{
    public int AdiId { get; set; }

    public int AdiAdhid { get; set; }

    public decimal AdiAmount { get; set; }

    public decimal AdiPercent { get; set; }

    public bool AdiArchival { get; set; }

    public int? AdiPositionId { get; set; }

    public string? AdiPositionName { get; set; }

    public bool? AdiPositionIsVat { get; set; }

    public DateTime? AdiModificationDate { get; set; }

    public int? AdiDdsid { get; set; }

    public int? AdiDcdid { get; set; }

    public virtual ICollection<DfWorkAdvalue> DfWorkAdvalues { get; set; } = new List<DfWorkAdvalue>();
}
