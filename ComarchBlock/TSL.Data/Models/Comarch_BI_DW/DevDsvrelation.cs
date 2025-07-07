using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DevDsvrelation
{
    public string DrelId { get; set; } = null!;

    public string? DrelName { get; set; }

    public string? DrelParentTableReferenceId { get; set; }

    public string? DrelParentColumnReferenceId { get; set; }

    public string? DrelChildTableReferenceId { get; set; }

    public string? DrelChildColumnReferenceId { get; set; }

    public string? DrelViewReferenceId { get; set; }
}
