using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class NamedCalculation
{
    public int Id { get; set; }

    public string? Tname { get; set; }

    public string? Fname { get; set; }

    public string? Value { get; set; }

    public string? Type { get; set; }

    public string? Nullable { get; set; }
}
