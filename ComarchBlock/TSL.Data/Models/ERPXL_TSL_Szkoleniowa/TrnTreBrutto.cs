using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class TrnTreBrutto
{
    public int? TrnGidtyp { get; set; }

    public int? TrnGidnumer { get; set; }

    public decimal? TrnBruttonag { get; set; }

    public decimal? TrnBruttoelem { get; set; }

    public decimal? TrnProporcja { get; set; }
}
