using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class RecNag
{
    public short? ReNGidtyp { get; set; }

    public int? ReNGidfirma { get; set; }

    public int ReNGidnumer { get; set; }

    public short? ReNGidlp { get; set; }

    public short? ReNTwrTyp { get; set; }

    public int? ReNTwrFirma { get; set; }

    public int? ReNTwrNumer { get; set; }

    public short? ReNTwrLp { get; set; }

    public string? ReNSymbol { get; set; }

    public string? ReNNazwa { get; set; }

    public decimal? ReNIlosc { get; set; }

    public string? ReNJmZ { get; set; }

    public byte? ReNTypJm { get; set; }

    public byte? ReNJmFormat { get; set; }

    public byte? ReNJmFormatZ { get; set; }

    public decimal? ReNPrzeliczM { get; set; }

    public decimal? ReNPrzeliczL { get; set; }

    public decimal? ReNKosztEwidencyjny { get; set; }

    public short? ReNTypKompletacji { get; set; }

    public short? ReNDomyslna { get; set; }

    public short? ReNRodzajKosztu { get; set; }

    public short? ReNGodzin { get; set; }

    public short? ReNMinut { get; set; }

    public short? ReNMagTyp { get; set; }

    public int? ReNMagFirma { get; set; }

    public int? ReNMagNumer { get; set; }

    public short? ReNMagLp { get; set; }

    public string? ReNOpis { get; set; }

    public short? ReNCchTyp { get; set; }

    public int? ReNCchFirma { get; set; }

    public int? ReNCchNumer { get; set; }

    public short? ReNCchLp { get; set; }

    public string? ReNCecha { get; set; }

    public short? ReNTypCechy { get; set; }

    public string? ReNUrl { get; set; }

    public int? ReNMagProdId { get; set; }

    public byte? ReNArchiwalna { get; set; }

    public virtual TwrKarty? ReNTwrNumerNavigation { get; set; }

    public virtual ICollection<RecElem> RecElems { get; set; } = new List<RecElem>();
}
