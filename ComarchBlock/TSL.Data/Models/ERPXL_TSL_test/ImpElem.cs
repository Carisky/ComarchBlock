using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ImpElem
{
    public short? ImEGidtyp { get; set; }

    public int? ImEGidfirma { get; set; }

    public int ImEGidnumer { get; set; }

    public short ImEGidlp { get; set; }

    public short? ImEPozycja { get; set; }

    public short? ImETwrTyp { get; set; }

    public int? ImETwrFirma { get; set; }

    public int? ImETwrNumer { get; set; }

    public short? ImETwrLp { get; set; }

    public byte? ImETypTwr { get; set; }

    public string? ImETwrNazwa { get; set; }

    public string? ImETwrKod { get; set; }

    public short? ImEKntTyp { get; set; }

    public int? ImEKntFirma { get; set; }

    public int? ImEKntNumer { get; set; }

    public short? ImEKntLp { get; set; }

    public short? ImEZaEtyp { get; set; }

    public int? ImEZaEfirma { get; set; }

    public int? ImEZaEnumer { get; set; }

    public short? ImEZaElp { get; set; }

    public decimal? ImEIlosc { get; set; }

    public byte? ImEJmFormat { get; set; }

    public string? ImEJmZ { get; set; }

    public byte? ImEJmFormatZ { get; set; }

    public byte? ImETypJm { get; set; }

    public decimal? ImEPrzeliczM { get; set; }

    public decimal? ImEPrzeliczL { get; set; }

    public decimal? ImEWartosc { get; set; }

    public int? ImETstamp { get; set; }

    public string? ImEOpis { get; set; }

    public decimal? ImECena { get; set; }

    public short? ImETrnTyp { get; set; }

    public int? ImETrnFirma { get; set; }

    public int? ImETrnNumer { get; set; }

    public short? ImETrnLp { get; set; }

    public byte? ImEPrecyzjaCeny { get; set; }

    public string? ImEKrajPoch { get; set; }

    public string? ImEPcn { get; set; }

    public short? ImEZwrTyp { get; set; }

    public int? ImEZwrNumer { get; set; }

    public short? ImEZwrLp { get; set; }

    public byte? ImERownanie { get; set; }

    public int? ImESentId { get; set; }

    public int? ImESentElemId { get; set; }

    public virtual ImpNag ImEGidnumerNavigation { get; set; } = null!;
}
