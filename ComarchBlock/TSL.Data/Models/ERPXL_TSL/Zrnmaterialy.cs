using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Zrnmaterialy
{
    public short? ZrmGidtyp { get; set; }

    public int? ZrmGidfirma { get; set; }

    public int ZrmGidnumer { get; set; }

    public short? ZrmGidlp { get; set; }

    public int? ZrmPozycja { get; set; }

    public short? ZrmZrntyp { get; set; }

    public int? ZrmZrnfirma { get; set; }

    public int? ZrmZrnnumer { get; set; }

    public short? ZrmZrnlp { get; set; }

    public short? ZrmTwrTyp { get; set; }

    public int? ZrmTwrFirma { get; set; }

    public int? ZrmTwrNumer { get; set; }

    public short? ZrmTwrLp { get; set; }

    public short? ZrmMagTyp { get; set; }

    public int? ZrmMagFirma { get; set; }

    public int? ZrmMagNumer { get; set; }

    public short? ZrmMagLp { get; set; }

    public short? ZrmTyp { get; set; }

    public short? ZrmKntTypO { get; set; }

    public int? ZrmKntFirmaO { get; set; }

    public int? ZrmKntNumerO { get; set; }

    public short? ZrmKntLpO { get; set; }

    public decimal? ZrmIlosc { get; set; }

    public string? ZrmJmZ { get; set; }

    public byte? ZrmTypJm { get; set; }

    public byte? ZrmJmFormat { get; set; }

    public byte? ZrmJmFormatZ { get; set; }

    public decimal? ZrmPrzeliczM { get; set; }

    public decimal? ZrmPrzeliczL { get; set; }

    public int? ZrmDataPobrania { get; set; }

    public string? ZrmCecha { get; set; }

    public short? ZrmCchtyp { get; set; }

    public int? ZrmCchfirma { get; set; }

    public int? ZrmCchnumer { get; set; }

    public short? ZrmCchlp { get; set; }

    public int? ZrmDataDostarczeniaKlientowi { get; set; }

    public int? ZrmDataZwrotu { get; set; }

    public int? ZrmTstamp { get; set; }

    public string? ZrmOpis { get; set; }

    public string? ZrmTwrNazwa { get; set; }

    public short? ZrmZlcTyp { get; set; }

    public short? ZrmReNtyp { get; set; }

    public int? ZrmReNfirma { get; set; }

    public int? ZrmReNnumer { get; set; }

    public short? ZrmReNlp { get; set; }

    public decimal? ZrmKosztRzeczywisty { get; set; }

    public decimal? ZrmKosztEwidencyjny { get; set; }

    public short? ZrmProdTyp { get; set; }

    public int? ZrmProdFirma { get; set; }

    public int? ZrmProdNumer { get; set; }

    public short? ZrmProdLp { get; set; }

    public short? ZrmZmnTyp { get; set; }

    public int? ZrmZmnFirma { get; set; }

    public int? ZrmZmnNumer { get; set; }

    public short? ZrmZmnLp { get; set; }

    public short? ZrmZrdTyp { get; set; }

    public int? ZrmZrdFirma { get; set; }

    public int? ZrmZrdNumer { get; set; }

    public short? ZrmZrdLp { get; set; }

    public short? ZrmZceTyp { get; set; }

    public int? ZrmZcEfirma { get; set; }

    public int? ZrmZcEnumer { get; set; }

    public short? ZrmZcElp { get; set; }

    public short? ZrmStalaIlosc { get; set; }

    public byte? ZrmZamiennik { get; set; }

    public virtual ZlcRemNag? ZrmZrnnumerNavigation { get; set; }
}
