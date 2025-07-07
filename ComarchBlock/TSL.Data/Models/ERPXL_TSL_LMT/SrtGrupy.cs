using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SrtGrupy
{
    public short SrGGidtyp { get; set; }

    public int? SrGGidfirma { get; set; }

    public int SrGGidnumer { get; set; }

    public short? SrGGidlp { get; set; }

    public short SrGGrOtyp { get; set; }

    public int? SrGGrOfirma { get; set; }

    public int SrGGrOnumer { get; set; }

    public short? SrGGrOlp { get; set; }

    public string? SrGAkronim { get; set; }

    public int? SrGCzasModyfikacji { get; set; }
}
