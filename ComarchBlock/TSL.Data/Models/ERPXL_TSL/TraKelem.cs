using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class TraKelem
{
    public short? TrkGidtyp { get; set; }

    public int? TrkGidfirma { get; set; }

    public int TrkGidnumer { get; set; }

    public short TrkGidlp { get; set; }

    public short? TrkPozycja { get; set; }

    public short? TrkTwrTyp { get; set; }

    public int? TrkTwrFirma { get; set; }

    public int? TrkTwrNumer { get; set; }

    public short? TrkTwrLp { get; set; }

    public decimal? TrkWartosc { get; set; }

    public virtual TraNag TrkGidnumerNavigation { get; set; } = null!;
}
