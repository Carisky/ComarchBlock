using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class FormulaParameter
{
    public int Id { get; set; }

    /// <summary>
    /// One2Many=false;
    /// </summary>
    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public decimal? Value { get; set; }

    public decimal? RangeFrom { get; set; }

    public decimal? RangeTo { get; set; }

    public decimal? Step { get; set; }

    public decimal? Precision { get; set; }

    public virtual User1 User { get; set; } = null!;
}
