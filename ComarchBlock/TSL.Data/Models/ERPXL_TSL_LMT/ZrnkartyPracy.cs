using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ZrnkartyPracy
{
    public short? ZrkGidtyp { get; set; }

    public int? ZrkGidfirma { get; set; }

    public int ZrkGidnumer { get; set; }

    public short? ZrkGidlp { get; set; }

    public short? ZrkZrNtyp { get; set; }

    public int? ZrkZrNfirma { get; set; }

    public int? ZrkZrNnumer { get; set; }

    public short? ZrkZrNlp { get; set; }

    public int? ZrkDataWyjazdu { get; set; }

    public short? ZrkPozycja { get; set; }

    public int? ZrkDataPrzyjazdu { get; set; }

    public int? ZrkTypStawkiId { get; set; }

    public decimal? ZrkStawkaZaKm { get; set; }

    public decimal? ZrkIloscKm { get; set; }

    public decimal? ZrkKosztPrzejazdu { get; set; }

    public int? ZrkKmid { get; set; }

    public int? ZrkOpoidw { get; set; }

    public int? ZrkOpoidp { get; set; }

    public string? ZrkOpis { get; set; }

    public byte? ZrkCzyFakturowac { get; set; }

    public short? ZrkZceTyp { get; set; }

    public int? ZrkZcEfirma { get; set; }

    public int? ZrkZcEnumer { get; set; }

    public short? ZrkZcElp { get; set; }

    public short? ZrkProdTyp { get; set; }

    public int? ZrkProdFirma { get; set; }

    public int? ZrkProdNumer { get; set; }

    public short? ZrkProdLp { get; set; }

    public byte? ZrkGenerujZapisWterminarzu { get; set; }

    public byte? ZrkZamknij { get; set; }

    public virtual ZlcRemNag? ZrkZrNnumerNavigation { get; set; }

    public virtual ICollection<ZrnkartyPracyPrc> ZrnkartyPracyPrcs { get; set; } = new List<ZrnkartyPracyPrc>();

    public virtual ICollection<ZrnkartyPracyUsl> ZrnkartyPracyUsls { get; set; } = new List<ZrnkartyPracyUsl>();
}
