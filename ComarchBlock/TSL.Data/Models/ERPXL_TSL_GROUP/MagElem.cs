using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class MagElem
{
    public short? MaEGidtyp { get; set; }

    public int MaEGidnumer { get; set; }

    public short MaEGidlp { get; set; }

    public short? MaEPozycja { get; set; }

    public short? MaETwrTyp { get; set; }

    public int? MaETwrNumer { get; set; }

    public string? MaETwrKod { get; set; }

    public short? MaECcktyp { get; set; }

    public int? MaECcknumer { get; set; }

    public string? MaECecha { get; set; }

    public short? MaECck2typ { get; set; }

    public int? MaECck2numer { get; set; }

    public string? MaECecha2 { get; set; }

    public string? MaEEan { get; set; }

    public int? MaEDataW { get; set; }

    public decimal? MaEIlosc { get; set; }

    public byte? MaEJmFormat { get; set; }

    public string? MaEJmZ { get; set; }

    public byte? MaEJmFormatZ { get; set; }

    public byte? MaETypJm { get; set; }

    public decimal? MaEPrzeliczM { get; set; }

    public decimal? MaEPrzeliczL { get; set; }

    public int? MaEJednostkaLog { get; set; }

    public int? MaETpaId { get; set; }

    public short? MaEOpeTyp { get; set; }

    public int? MaEOpeFirma { get; set; }

    public int? MaEOpeNumer { get; set; }

    public short? MaEOpeLp { get; set; }

    public string? MaEOpis { get; set; }

    public byte? MaEStatus { get; set; }

    public decimal? MaEIloscMin { get; set; }

    public decimal? MaEIloscMax { get; set; }

    public byte? MaEJlogWms { get; set; }

    public virtual MagNag MaEGidnumerNavigation { get; set; } = null!;

    public virtual ICollection<MagLelem> MagLelems { get; set; } = new List<MagLelem>();

    public virtual ICollection<MagPelemArc> MagPelemArcs { get; set; } = new List<MagPelemArc>();

    public virtual ICollection<MagSelemArc> MagSelemArcs { get; set; } = new List<MagSelemArc>();
}
