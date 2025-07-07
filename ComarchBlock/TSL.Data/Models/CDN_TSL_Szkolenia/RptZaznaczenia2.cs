using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class RptZaznaczenia2
{
    public string RpZ2Guid { get; set; } = null!;

    public int RpZ2RekordLp { get; set; }

    public short? RpZ2Gidtyp { get; set; }

    public int? RpZ2Gidfirma { get; set; }

    public int? RpZ2Gidnumer { get; set; }

    public short? RpZ2Gidlp { get; set; }

    public short RpZ2KopiaLp { get; set; }
}
