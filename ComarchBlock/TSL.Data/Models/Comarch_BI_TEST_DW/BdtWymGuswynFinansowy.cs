using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymGuswynFinansowy
{
    public int GuswynId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? GuswynRowId { get; set; }

    public string? GuswynOpis { get; set; }

    public string GuswynNazwa { get; set; } = null!;
}
