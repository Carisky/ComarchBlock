using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KntOpiekun
{
    public short KtOKntTyp { get; set; }

    public int KtOKntNumer { get; set; }

    public short KtOKntLp { get; set; }

    public int KtOPrcNumer { get; set; }

    public int KtODataOd { get; set; }

    public int KtODataDo { get; set; }

    public byte? KtOGlowny { get; set; }

    public short? KtOOpeTyp { get; set; }

    public int? KtOOpeFirma { get; set; }

    public int? KtOOpeNumer { get; set; }

    public short? KtOOpeLp { get; set; }

    public short? KtOOpeTypM { get; set; }

    public int? KtOOpeFirmaM { get; set; }

    public int? KtOOpeNumerM { get; set; }

    public short? KtOOpeLpM { get; set; }

    public string? KtOUwagi { get; set; }

    public int? KtOCzasPrzypisania { get; set; }

    public int? KtOCzasModyfikacji { get; set; }
}
