using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ZlcElem
{
    public short? ZcEGidtyp { get; set; }

    public int? ZcEGidfirma { get; set; }

    public int ZcEGidnumer { get; set; }

    public short ZcEGidlp { get; set; }

    public short? ZcETwrTyp { get; set; }

    public int? ZcETwrFirma { get; set; }

    public int? ZcETwrNumer { get; set; }

    public short? ZcETwrLp { get; set; }

    public string? ZcETwrNazwa { get; set; }

    public short? ZcEReNtyp { get; set; }

    public int? ZcEReNfirma { get; set; }

    public int? ZcEReNnumer { get; set; }

    public short? ZcEReNlp { get; set; }

    public short? ZcETyp { get; set; }

    public short? ZcECchTyp { get; set; }

    public int? ZcECchFirma { get; set; }

    public int? ZcECchNumer { get; set; }

    public short? ZcECchLp { get; set; }

    public string? ZcECecha { get; set; }

    public short? ZcEMagTyp { get; set; }

    public int? ZcEMagFirma { get; set; }

    public int? ZcEMagNumer { get; set; }

    public short? ZcEMagLp { get; set; }

    public int? ZcETstamp { get; set; }

    public decimal? ZcEIlosc { get; set; }

    public string? ZcEJmZ { get; set; }

    public byte? ZcETypJm { get; set; }

    public byte? ZcEJmFormat { get; set; }

    public byte? ZcEJmFormatZ { get; set; }

    public decimal? ZcEPrzeliczM { get; set; }

    public decimal? ZcEPrzeliczL { get; set; }

    public decimal? ZcEKosztRzeczywisty { get; set; }

    public decimal? ZcEKosztEwidencyjny { get; set; }

    public short? ZcEZmnTyp { get; set; }

    public int? ZcEZmnFirma { get; set; }

    public int? ZcEZmnNumer { get; set; }

    public short? ZcEZmnLp { get; set; }

    public short? ZcEKntTyp { get; set; }

    public int? ZcEKntFirma { get; set; }

    public int? ZcEKntNumer { get; set; }

    public short? ZcEKntLp { get; set; }

    public short? ZcEProdTyp { get; set; }

    public int? ZcEProdFirma { get; set; }

    public int? ZcEProdNumer { get; set; }

    public short? ZcEProdLp { get; set; }

    public string? ZcEOpis { get; set; }

    public short? ZcEZrdTyp { get; set; }

    public int? ZcEZrdFirma { get; set; }

    public int? ZcEZrdNumer { get; set; }

    public short? ZcEZrdLp { get; set; }

    public short? ZcEPozycja { get; set; }

    public byte? ZcEStalaIlosc { get; set; }

    public int? ZcEDataRealizacji { get; set; }

    public virtual ZlcNag ZcEGidnumerNavigation { get; set; } = null!;
}
