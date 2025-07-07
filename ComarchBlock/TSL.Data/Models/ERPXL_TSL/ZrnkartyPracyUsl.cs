using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ZrnkartyPracyUsl
{
    public short? ZruGidtyp { get; set; }

    public int? ZruGidfirma { get; set; }

    public int ZruGidnumer { get; set; }

    public short? ZruGidlp { get; set; }

    public short? ZruSubGidlp { get; set; }

    public int? ZruSsCid { get; set; }

    public int? ZruPozycja { get; set; }

    public short? ZruZrntyp { get; set; }

    public int? ZruZrnfirma { get; set; }

    public int? ZruZrnnumer { get; set; }

    public short? ZruZrnlp { get; set; }

    public short? ZruTwrTyp { get; set; }

    public int? ZruTwrFirma { get; set; }

    public int? ZruTwrNumer { get; set; }

    public short? ZruTwrLp { get; set; }

    public short? ZruKntTypO { get; set; }

    public int? ZruKntFirmaO { get; set; }

    public int? ZruKntNumerO { get; set; }

    public short? ZruKntLpO { get; set; }

    public decimal? ZruIlosc { get; set; }

    public string? ZruJmZ { get; set; }

    public byte? ZruTypJm { get; set; }

    public byte? ZruJmFormat { get; set; }

    public byte? ZruJmFormatZ { get; set; }

    public decimal? ZruPrzeliczM { get; set; }

    public decimal? ZruPrzeliczL { get; set; }

    public decimal? ZruCzasZdefiniowany { get; set; }

    public decimal? ZruCzasRzeczywisty { get; set; }

    public decimal? ZruKosztJednostkowy { get; set; }

    public decimal? ZruKosztCalkowity { get; set; }

    public byte? ZruTypKosztu { get; set; }

    public decimal? ZruKoszt { get; set; }

    public byte? ZruCzyFakturowac { get; set; }

    public string? ZruOpis { get; set; }

    public short? ZruZcEtyp { get; set; }

    public int? ZruZcEfirma { get; set; }

    public int? ZruZcEnumer { get; set; }

    public short? ZruZcElp { get; set; }

    public decimal? ZruKosztRzeczywisty { get; set; }

    public short? ZruProdTyp { get; set; }

    public int? ZruProdFirma { get; set; }

    public int? ZruProdNumer { get; set; }

    public short? ZruProdLp { get; set; }

    public short? ZruStalaIlosc { get; set; }

    public virtual ZrnkartyPracy? ZruZrnnumerNavigation { get; set; }
}
