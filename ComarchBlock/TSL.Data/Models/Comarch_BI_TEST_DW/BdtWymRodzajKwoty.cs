using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymRodzajKwoty
{
    public int RkwotyId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? RkwotyRowId { get; set; }

    public string RkwotyOperator { get; set; } = null!;

    public string? RkwotyNazwa { get; set; }

    public int RkwotyOrgId { get; set; }
}
