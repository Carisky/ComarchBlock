using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Rezerwacje
{
    public short? RezGidtyp { get; set; }

    public int? RezGidfirma { get; set; }

    public int RezGidnumer { get; set; }

    public short? RezGidlp { get; set; }

    public short? RezTwrTyp { get; set; }

    public int? RezTwrFirma { get; set; }

    public int? RezTwrNumer { get; set; }

    public short? RezTwrLp { get; set; }

    public short? RezKntTyp { get; set; }

    public int? RezKntFirma { get; set; }

    public int? RezKntNumer { get; set; }

    public short? RezKntLp { get; set; }

    public short? RezZrdTyp { get; set; }

    public int? RezZrdFirma { get; set; }

    public int? RezZrdNumer { get; set; }

    public short? RezZrdLp { get; set; }

    public short? RezZrdSubLp { get; set; }

    public short? RezOpeTyp { get; set; }

    public int? RezOpeFirma { get; set; }

    public int? RezOpeNumer { get; set; }

    public short? RezOpeLp { get; set; }

    public short? RezMagTyp { get; set; }

    public int? RezMagFirma { get; set; }

    public int? RezMagNumer { get; set; }

    public short? RezMagLp { get; set; }

    public short? RezDstTyp { get; set; }

    public int? RezDstFirma { get; set; }

    public int? RezDstNumer { get; set; }

    public short? RezDstLp { get; set; }

    public decimal? RezIlosc { get; set; }

    public decimal? RezZrealizowano { get; set; }

    public decimal? RezIloscMag { get; set; }

    public decimal? RezIloscImp { get; set; }

    public decimal? RezIloscSsc { get; set; }

    public decimal? RezIloscSad { get; set; }

    public int? RezTstamp { get; set; }

    public int? RezDataRealizacji { get; set; }

    public int? RezDataWaznosci { get; set; }

    public int? RezDataAktywacji { get; set; }

    public byte? RezAktywna { get; set; }

    public short? RezZrodlo { get; set; }

    public int? RezDataPotwDst { get; set; }

    public int? RezFrsId { get; set; }

    public byte? RezTyp { get; set; }

    public byte? RezPriorytet { get; set; }

    public int? RezDataRezerwacji { get; set; }

    public int RezBsStwrNumer { get; set; }

    public int RezBsNid { get; set; }

    public short RezBsSrodzaj { get; set; }

    public int? RezPtzid { get; set; }

    public int? RezCchnumer { get; set; }

    public string? RezCecha { get; set; }

    public string? RezOpis { get; set; }

    public string? RezGuid { get; set; }

    public virtual ICollection<RezMagazyny> RezMagazynies { get; set; } = new List<RezMagazyny>();
}
