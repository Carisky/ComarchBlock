using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymGustowaryGr
{
    public int GustwrGrId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? GustwrGrRowId { get; set; }

    public string? GustwrGrOpis { get; set; }

    public string GustwrGrNazwa { get; set; } = null!;
}
