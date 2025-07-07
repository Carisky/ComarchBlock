using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymRodzajKwoty
{
    public int RkwotyId { get; set; }

    public int RkwotyOrgId { get; set; }

    public string? RkwotyNazwa { get; set; }

    public string RkwotyOperator { get; set; } = null!;
}
