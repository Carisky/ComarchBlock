using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TraElemAtr
{
    public int TrATrAid { get; set; }

    public int TrATrEid { get; set; }

    public int TrALp { get; set; }

    public int TrADeAid { get; set; }

    public string TrAKod { get; set; } = null!;

    public string TrAWartosc { get; set; } = null!;

    public short TrAEsklep { get; set; }

    public int? TrADokTyp { get; set; }

    public int? TrADokId { get; set; }

    public int? TrATwrId { get; set; }
}
