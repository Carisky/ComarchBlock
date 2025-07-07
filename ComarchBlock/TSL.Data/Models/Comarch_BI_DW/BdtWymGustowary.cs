using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymGustowary
{
    public int GustwrId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? GustwrRowId { get; set; }

    public string? GustwrOpis { get; set; }

    public string GustwrNazwa { get; set; } = null!;
}
