using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class KntUpusty
{
    public short? KnUKntTyp { get; set; }

    public int? KnUKntFirma { get; set; }

    public int? KnUKntNumer { get; set; }

    public int? KnUKntLp { get; set; }

    public short? KnUTwgTyp { get; set; }

    public int? KnUTwgFirma { get; set; }

    public int? KnUTwgNumer { get; set; }

    public short? KnUTwgLp { get; set; }

    public decimal? KnUUpust { get; set; }

    public string? KnUUpustWzor { get; set; }

    public string? KnUSymbol { get; set; }

    public short? KnUNrKursu { get; set; }

    public string? KnUFlagaNb { get; set; }

    public string? KnUNotatki { get; set; }

    public int KnUTprid { get; set; }

    public int? KnUTyp { get; set; }
}
