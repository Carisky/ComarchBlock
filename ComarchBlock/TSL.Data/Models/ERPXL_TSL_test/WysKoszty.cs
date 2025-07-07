using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class WysKoszty
{
    public short WyKDokTyp { get; set; }

    public int? WyKDokFirma { get; set; }

    public int WyKDokNumer { get; set; }

    public short? WyKDokLp { get; set; }

    public short? WyKWysTyp { get; set; }

    public int? WyKWysFirma { get; set; }

    public int WyKWysNumer { get; set; }

    public short? WyKWysLp { get; set; }

    public decimal? WyKProcent { get; set; }

    public decimal? WyKKwota { get; set; }

    public virtual Wysylki WyKWysNumerNavigation { get; set; } = null!;
}
