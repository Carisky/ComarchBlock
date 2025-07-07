using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class IstNag
{
    public short? IsNGidtyp { get; set; }

    public int? IsNGidfirma { get; set; }

    public int IsNGidnumer { get; set; }

    public short? IsNGidlp { get; set; }

    public byte? IsNSzczegolowosc { get; set; }

    public byte? IsNGrupujDrobne { get; set; }

    public short? IsNUrzTyp { get; set; }

    public int? IsNUrzFirma { get; set; }

    public int? IsNUrzNumer { get; set; }

    public short? IsNUrzLp { get; set; }

    public string? IsNTyp { get; set; }

    public string? IsNRodzaj { get; set; }

    public short? IsNRok { get; set; }

    public short? IsNMiesiac { get; set; }

    public int? IsNNumer { get; set; }

    public int? IsNWersja { get; set; }

    public decimal? IsNWartoscFakt { get; set; }

    public decimal? IsNWartoscStat { get; set; }

    public int? IsNIloscPozycji { get; set; }

    public string? IsNMiasto { get; set; }

    public int? IsNData { get; set; }

    public short? IsNKntTyp { get; set; }

    public int? IsNKntFirma { get; set; }

    public int? IsNKntNumer { get; set; }

    public short? IsNKntLp { get; set; }

    public byte? IsNStan { get; set; }

    public int? IsNAktywny { get; set; }

    public short? IsNOpeTypW { get; set; }

    public int? IsNOpeFirmaW { get; set; }

    public int? IsNOpeNumerW { get; set; }

    public short? IsNOpeLpW { get; set; }

    public short? IsNOpeTypM { get; set; }

    public int? IsNOpeFirmaM { get; set; }

    public int? IsNOpeNumerM { get; set; }

    public short? IsNOpeLpM { get; set; }

    public short? IsNOpeTypZ { get; set; }

    public int? IsNOpeFirmaZ { get; set; }

    public int? IsNOpeNumerZ { get; set; }

    public short? IsNOpeLpZ { get; set; }

    public string? IsNImie { get; set; }

    public string? IsNNazwisko { get; set; }

    public string? IsNTelefon { get; set; }

    public string? IsNFaks { get; set; }

    public string? IsNEmail { get; set; }

    public string? IsNEmailZwr { get; set; }

    public virtual ICollection<IstElem> IstElems { get; set; } = new List<IstElem>();
}
