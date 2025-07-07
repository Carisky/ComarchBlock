using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class TwrDostCeny
{
    public int TdcId { get; set; }

    public int? TdcTwdId { get; set; }

    public decimal? TdcCena { get; set; }

    public string? TdcWaluta { get; set; }

    public short? TdcNrKursu { get; set; }

    public int? TdcDataOd { get; set; }

    public int? TdcCzasModyfikacji { get; set; }

    public virtual TwrDost? TdcTwd { get; set; }
}
