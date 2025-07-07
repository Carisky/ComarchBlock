using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class Link
{
    public int TableId { get; set; }

    public string? FctName { get; set; }

    public string? ViewFctName { get; set; }

    public string? VName { get; set; }

    public string? BdtName { get; set; }

    public string? DsvName { get; set; }
}
