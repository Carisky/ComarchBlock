using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class RecElem
{
    public short? ReEGidtyp { get; set; }

    public int? ReEGidfirma { get; set; }

    public int ReEGidnumer { get; set; }

    public short ReEGidlp { get; set; }

    public short? ReETwrTyp { get; set; }

    public int? ReETwrFirma { get; set; }

    public int? ReETwrNumer { get; set; }

    public short? ReETwrLp { get; set; }

    public short? ReEWarstwa { get; set; }

    public decimal? ReEIlosc { get; set; }

    public string? ReEJmZ { get; set; }

    public byte? ReETypJm { get; set; }

    public byte? ReEJmFormat { get; set; }

    public byte? ReEJmFormatZ { get; set; }

    public decimal? ReEPrzeliczM { get; set; }

    public decimal? ReEPrzeliczL { get; set; }

    public decimal? ReEUbytek { get; set; }

    public byte? ReEZamiennik { get; set; }

    public short? ReETypPozycji { get; set; }

    public short? ReEMagTyp { get; set; }

    public int? ReEMagFirma { get; set; }

    public int? ReEMagNumer { get; set; }

    public short? ReEMagLp { get; set; }

    public decimal? ReEKoszt { get; set; }

    public string? ReEOpis { get; set; }

    public short? ReECchTyp { get; set; }

    public int? ReECchFirma { get; set; }

    public int? ReECchNumer { get; set; }

    public short? ReECchLp { get; set; }

    public string? ReECecha { get; set; }

    public short? ReETypCechy { get; set; }

    public byte? ReEStalaIlosc { get; set; }

    public int? ReEMagProdId { get; set; }

    public byte? ReEArchiwalny { get; set; }

    public virtual RecNag ReEGidnumerNavigation { get; set; } = null!;
}
