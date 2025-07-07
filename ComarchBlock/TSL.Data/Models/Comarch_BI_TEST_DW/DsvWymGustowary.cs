using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymGustowary
{
    public int GustwrId { get; set; }

    public string GustwrNazwa { get; set; } = null!;

    public string? GustwrOpis { get; set; }

    public int? GustwrRowId { get; set; }
}
