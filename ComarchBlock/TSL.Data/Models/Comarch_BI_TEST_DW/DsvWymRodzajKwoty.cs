using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymRodzajKwoty
{
    public int RkwotyId { get; set; }

    public string? RkwotyNazwa { get; set; }

    public string RkwotyOperator { get; set; } = null!;

    public int RkwotyOrgId { get; set; }
}
