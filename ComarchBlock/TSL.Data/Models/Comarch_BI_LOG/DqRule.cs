using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class DqRule
{
    public int DqrCode { get; set; }

    public int DqrOrder { get; set; }

    public string? DqrDependent { get; set; }

    public string DqrName { get; set; } = null!;

    public string? DqrDescription { get; set; }

    public string? DqrType { get; set; }

    public string? DqrLevel { get; set; }

    public bool DqrActive { get; set; }

    public bool? DqrIsStandard { get; set; }

    public int? DqrWarningFrom { get; set; }

    public int? DqrWarningTo { get; set; }

    public string? DqrExpectedValue { get; set; }

    public virtual ICollection<DqOutput> DqOutputs { get; set; } = new List<DqOutput>();
}
