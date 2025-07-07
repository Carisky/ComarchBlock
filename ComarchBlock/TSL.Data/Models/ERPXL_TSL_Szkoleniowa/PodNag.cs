using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PodNag
{
    public short? PonGidtyp { get; set; }

    public int? PonGidfirma { get; set; }

    public int PonGidnumer { get; set; }

    public short? PonGidlp { get; set; }

    public short? PonUstyp { get; set; }

    public int? PonUsfirma { get; set; }

    public int? PonUsnumer { get; set; }

    public short? PonUslp { get; set; }

    public short? PonWlatyp { get; set; }

    public int? PonWlafirma { get; set; }

    public int? PonWlanumer { get; set; }

    public short? PonWlalp { get; set; }

    public short? PonTypPodatku { get; set; }

    public short? PonWersja { get; set; }

    public short? PonRok { get; set; }

    public short? PonKwartal { get; set; }

    public short? PonMiesiac { get; set; }

    public int? PonOkrPoczatek { get; set; }

    public string? PonOkrSymbol { get; set; }

    public int? PonOkresId { get; set; }

    public int? PonIdentyfikator { get; set; }

    public int? PonKorekta { get; set; }

    public int? PonZrodlo { get; set; }

    public int? PonTstamp { get; set; }

    public string? PonCechaOpis { get; set; }

    public string? PonDziennik { get; set; }

    public byte? PonZaksiegowano { get; set; }

    public byte? PonNieKsiegowac { get; set; }

    public int? PonDataKsiegowania { get; set; }

    public short? PonSchtyp { get; set; }

    public int? PonSchfirma { get; set; }

    public int? PonSchnumer { get; set; }

    public short? PonSchlp { get; set; }

    public short? PonOpetyp { get; set; }

    public int? PonOpefirma { get; set; }

    public int? PonOpenumer { get; set; }

    public short? PonOpelp { get; set; }

    public short? PonOpemtyp { get; set; }

    public int? PonOpemfirma { get; set; }

    public int? PonOpemnumer { get; set; }

    public short? PonOpemlp { get; set; }

    public short? PonOpeztyp { get; set; }

    public int? PonOpezfirma { get; set; }

    public int? PonOpeznumer { get; set; }

    public short? PonOpezlp { get; set; }

    public short? PonOpektyp { get; set; }

    public int? PonOpekfirma { get; set; }

    public int? PonOpeknumer { get; set; }

    public short? PonOpeklp { get; set; }

    public int? PonNumer { get; set; }

    public decimal? PonStrukturaSprzedazy { get; set; }

    public byte? PonSzacunkowy { get; set; }

    public string? PonNrProtokolu { get; set; }

    public byte? PonStatus { get; set; }

    public int? PonDpnid { get; set; }

    public int? PonGlowna { get; set; }

    public short? PonWsSchtyp { get; set; }

    public int? PonWsSchnumer { get; set; }

    public byte? PonWsStosujSchemat { get; set; }

    public string? PonWsDziennik { get; set; }

    public byte? PonWsStosujDziennik { get; set; }

    public string? PonUwagi { get; set; }

    public int? PonPozid { get; set; }

    public string? PonZnakNrDecyzjiPok { get; set; }

    public int? PonDataWprowadzenia { get; set; }

    public int? PonDataModyfikacji { get; set; }

    public int? PonDataWyp { get; set; }

    public int? PonDataNaDzien { get; set; }

    public int? PonDataObliczenia { get; set; }

    public int? PonPrcnumer { get; set; }

    public string? PonKodUbezpieczenia { get; set; }

    public string? PonTrescUzasadnienia { get; set; }

    public byte? PonZaokraglajWskaznikStr { get; set; }

    public int? PonDataOd { get; set; }

    public int? PonDataDo { get; set; }

    public string? PonParamS1 { get; set; }

    public string? PonParamS2 { get; set; }

    public string? PonParamS3 { get; set; }

    public int? PonParamL1 { get; set; }

    public int? PonParamL2 { get; set; }

    public string? PonUrl { get; set; }

    public int? PonAktywny { get; set; }

    public int? PonOptimaId { get; set; }

    public string? PonUnross { get; set; }

    public string? PonWaluta { get; set; }

    public short? PonNrKursu { get; set; }

    public decimal? PonKursL { get; set; }

    public decimal? PonKursM { get; set; }

    public byte? PonDokZaksiegowane { get; set; }

    public virtual ICollection<PodElem> PodElems { get; set; } = new List<PodElem>();
}
