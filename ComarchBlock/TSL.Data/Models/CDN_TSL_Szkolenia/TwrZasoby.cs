using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TwrZasoby
{
    public int TwZTwZid { get; set; }

    public int? TwZTrSidDost { get; set; }

    public int TwZTwrId { get; set; }

    public int TwZMagId { get; set; }

    public DateTime? TwZData { get; set; }

    public decimal TwZIlosc { get; set; }

    public decimal TwZQuan { get; set; }

    public decimal TwZWartosc { get; set; }

    public decimal TwZCena { get; set; }

    public virtual Magazyny TwZMag { get; set; } = null!;

    public virtual Towary TwZTwr { get; set; } = null!;
}
