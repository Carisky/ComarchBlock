using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class KntGrupy
{
    public short KnGGidtyp { get; set; }

    public int? KnGGidfirma { get; set; }

    public int KnGGidnumer { get; set; }

    public short? KnGGidlp { get; set; }

    public short KnGGrOtyp { get; set; }

    public int? KnGGrOfirma { get; set; }

    public int KnGGrOnumer { get; set; }

    public short? KnGGrOlp { get; set; }

    public string? KnGAkronim { get; set; }

    public int? KnGCzasModyfikacji { get; set; }
}
