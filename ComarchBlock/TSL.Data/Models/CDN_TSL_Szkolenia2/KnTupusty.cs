using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class KnTupusty
{
    public short? KnUKntTyp { get; set; }

    public int? KnuKntFirma { get; set; }

    public int? KnuKntNumer { get; set; }

    public int KnuKntLp { get; set; }

    public short? KnuTwgTyp { get; set; }

    public int? KnuTwgFirma { get; set; }

    public int? KnuTwgNumer { get; set; }

    public short? KnuTwgLp { get; set; }

    public decimal? KnUUpust { get; set; }

    public string KnUUpustWzor { get; set; } = null!;

    public string? KnUSymbol { get; set; }

    public int KnUNrKursu { get; set; }

    public string? KnUFlagaNb { get; set; }

    public string? KnUNotatki { get; set; }
}
