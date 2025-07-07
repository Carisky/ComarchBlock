using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkAdvalue
{
    public int AdvId { get; set; }

    public int AdvAdiid { get; set; }

    public int AdvAddid { get; set; }

    public string AdvName { get; set; } = null!;

    public int AdvNatSystemId { get; set; }

    public bool AdvArchival { get; set; }

    public string? AdvElementName { get; set; }

    public DateTime? AdvModificationDate { get; set; }

    public int? AdvDdsid { get; set; }

    public int? AdvDcdid { get; set; }

    public byte AdvType { get; set; }

    public virtual DfWorkAddimension AdvAdd { get; set; } = null!;

    public virtual DfWorkAditem AdvAdi { get; set; } = null!;
}
