using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymGustowaryGr
{
    public int GustwrGrId { get; set; }

    public string GustwrGrNazwa { get; set; } = null!;

    public string? GustwrGrOpis { get; set; }

    public int? GustwrGrRowId { get; set; }
}
