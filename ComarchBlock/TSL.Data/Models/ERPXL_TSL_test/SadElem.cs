using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class SadElem
{
    public short? SaEGidtyp { get; set; }

    public int? SaEGidfirma { get; set; }

    public int SaEGidnumer { get; set; }

    public short SaEGidlp { get; set; }

    public short? SaEPozycja { get; set; }

    public short? SaETwrTyp { get; set; }

    public int? SaETwrFirma { get; set; }

    public int? SaETwrNumer { get; set; }

    public short? SaETwrLp { get; set; }

    public byte? SaETypTwr { get; set; }

    public string? SaETwrNazwa { get; set; }

    public string? SaETwrKod { get; set; }

    public short? SaEImpTyp { get; set; }

    public int? SaEImpFirma { get; set; }

    public int? SaEImpNumer { get; set; }

    public short? SaEImpLp { get; set; }

    public short? SaEZaEtyp { get; set; }

    public int? SaEZaEfirma { get; set; }

    public int? SaEZaEnumer { get; set; }

    public short? SaEZaElp { get; set; }

    public decimal? SaEIlosc { get; set; }

    public byte? SaEJmFormat { get; set; }

    public string? SaEJmZ { get; set; }

    public byte? SaEJmFormatZ { get; set; }

    public byte? SaETypJm { get; set; }

    public decimal? SaEPrzeliczM { get; set; }

    public decimal? SaEPrzeliczL { get; set; }

    public int? SaETstamp { get; set; }

    public string? SaEOpis { get; set; }

    public decimal? SaEObjetosc { get; set; }

    public decimal? SaEWagaNetto { get; set; }

    public decimal? SaEWagaBrutto { get; set; }

    public string? SaEWjm { get; set; }

    public string? SaEKrajPoch { get; set; }

    public byte? SaEKosztVat { get; set; }

    public byte? SaEKosztNetto { get; set; }

    public decimal? SaECena { get; set; }

    public byte? SaEPrecyzjaCeny { get; set; }

    public string? SaEPcn { get; set; }

    public byte? SaEKatDatyOp { get; set; }

    public virtual SadNag SaEGidnumerNavigation { get; set; } = null!;

    public virtual ICollection<SadSelem> SadSelems { get; set; } = new List<SadSelem>();
}
