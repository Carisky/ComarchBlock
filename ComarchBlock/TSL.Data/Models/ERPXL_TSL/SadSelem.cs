using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class SadSelem
{
    public short? SaSGidtyp { get; set; }

    public int? SaSGidfirma { get; set; }

    public int SaSGidnumer { get; set; }

    public short SaSGidlp { get; set; }

    public short SaSSubGidlp { get; set; }

    public short? SaSDstTyp { get; set; }

    public int? SaSDstFirma { get; set; }

    public int? SaSDstNumer { get; set; }

    public short? SaSDstLp { get; set; }

    public short? SaSSctyp { get; set; }

    public int? SaSScfirma { get; set; }

    public int? SaSScnumer { get; set; }

    public short? SaSSclp { get; set; }

    public decimal? SaSIlosc { get; set; }

    public short? SaSCchTyp { get; set; }

    public int? SaSCchFirma { get; set; }

    public int? SaSCchNumer { get; set; }

    public short? SaSCchLp { get; set; }

    public string? SaSCecha { get; set; }

    public decimal? SaSWartoscDostawy { get; set; }

    public decimal? SaSKosztKraj { get; set; }

    public decimal? SaSKosztZagr { get; set; }

    public int? SaSTstamp { get; set; }

    public string? SaSWaluta { get; set; }

    public string? SaSWalutaKosztuKrajowego { get; set; }

    public string? SaSWalutaKosztuZagranicznego { get; set; }

    public short? SaSZwrTyp { get; set; }

    public int? SaSZwrNumer { get; set; }

    public short? SaSZwrLp { get; set; }

    public short? SaSSubZwrLp { get; set; }

    public virtual SadElem SadElem { get; set; } = null!;
}
