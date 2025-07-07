using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ZamElem
{
    public short? ZaEGidtyp { get; set; }

    public int? ZaEGidfirma { get; set; }

    public int ZaEGidnumer { get; set; }

    public short ZaEGidlp { get; set; }

    public short? ZaETwrTyp { get; set; }

    public int? ZaETwrFirma { get; set; }

    public int? ZaETwrNumer { get; set; }

    public short? ZaETwrLp { get; set; }

    public string? ZaETwrNazwa { get; set; }

    public string? ZaETwrKod { get; set; }

    public short? ZaEKntTyp { get; set; }

    public int? ZaEKntFirma { get; set; }

    public int? ZaEKntNumer { get; set; }

    public short? ZaEKntLp { get; set; }

    public short? ZaEAkwTyp { get; set; }

    public int? ZaEAkwFirma { get; set; }

    public int? ZaEAkwNumer { get; set; }

    public short? ZaEAkwLp { get; set; }

    public short? ZaECchTyp { get; set; }

    public int? ZaECchFirma { get; set; }

    public int? ZaECchNumer { get; set; }

    public short? ZaECchLp { get; set; }

    public short? ZaEMagTyp { get; set; }

    public int? ZaEMagFirma { get; set; }

    public int? ZaEMagNumer { get; set; }

    public short? ZaEMagLp { get; set; }

    public int? ZaETstamp { get; set; }

    public decimal? ZaEIlosc { get; set; }

    public string? ZaEJmZ { get; set; }

    public byte? ZaETypJm { get; set; }

    public byte? ZaEJmFormat { get; set; }

    public byte? ZaEJmFormatZ { get; set; }

    public decimal? ZaEPrzeliczM { get; set; }

    public decimal? ZaEPrzeliczL { get; set; }

    public string? ZaEGrupaPod { get; set; }

    public decimal? ZaEStawkaPod { get; set; }

    public byte? ZaEFlagaVat { get; set; }

    public decimal? ZaEZrodlowa { get; set; }

    public string? ZaEWaluta { get; set; }

    public short? ZaENrKursu { get; set; }

    public decimal? ZaERabat { get; set; }

    public string? ZaECecha { get; set; }

    public decimal? ZaECenaKatalogowa { get; set; }

    public decimal? ZaECenaOferowana { get; set; }

    public decimal? ZaECenaUzgodniona { get; set; }

    public short? ZaERodzajCenyBazowej { get; set; }

    public byte? ZaEProgTyp { get; set; }

    public decimal? ZaEProg { get; set; }

    public byte? ZaEUpustTyp { get; set; }

    public decimal? ZaEUpust { get; set; }

    public byte? ZaEUpustKntTyp { get; set; }

    public decimal? ZaEUpustKnt { get; set; }

    public short? ZaEReEtyp { get; set; }

    public int? ZaEReEfirma { get; set; }

    public int? ZaEReEnumer { get; set; }

    public short? ZaEReElp { get; set; }

    public short? ZaEReEprodLp { get; set; }

    public int? ZaEDataWaznosciRez { get; set; }

    public decimal? ZaEWartoscPoRabacie { get; set; }

    public int? ZaEDataPotwDst { get; set; }

    public int? ZaEDataAktywacjiRez { get; set; }

    public int? ZaEDataOdZam { get; set; }

    public byte? ZaEPrecyzjaCeny { get; set; }

    public byte? ZaERownanie { get; set; }

    public string? ZaEFlagaNb { get; set; }

    public short? ZaELicencja { get; set; }

    public short? ZaEPozycja { get; set; }

    public decimal? ZaERabatPromocyjny { get; set; }

    public decimal? ZaERabatKorekta { get; set; }

    public int? ZaEPromocje { get; set; }

    public short? ZaEZstTyp { get; set; }

    public int? ZaEZstFirma { get; set; }

    public int? ZaEZstNumer { get; set; }

    public short? ZaEZstLp { get; set; }

    public short? ZaEPrecyzjaCenyPocz { get; set; }

    public short? ZaECenaSpr { get; set; }

    public short? ZaERodzajDatyRealizacji { get; set; }

    public decimal? ZaEKgojednostkowe { get; set; }

    public int? ZaEOddElemId { get; set; }

    public decimal? ZaEIloscMin { get; set; }

    public decimal? ZaEIloscMax { get; set; }

    public int? ZaEPakietId { get; set; }

    public short? ZaEGratis { get; set; }

    public int? ZaEPromocjaProgId { get; set; }

    public short? ZaEZlom { get; set; }

    public byte? ZaEFormatkaCyr { get; set; }

    public int? ZaEKpnid { get; set; }

    public byte? ZaETypCenyNabycia { get; set; }

    public byte? ZaEPakietWymaganaPoz { get; set; }

    public int? ZaEPakietTwgNumer { get; set; }

    public short? ZaEPakietTwgTyp { get; set; }

    public decimal? ZaERabatOpeGen { get; set; }

    public int? ZaEWymuszonePrmid { get; set; }

    public decimal? ZaEPunkty { get; set; }

    public short? ZaENagroda { get; set; }

    public int? ZaEReNnumer { get; set; }

    public byte? ZaEOplataSpozFlaga { get; set; }

    public decimal? ZaEStawkaCukierStala { get; set; }

    public decimal? ZaEStawkaCukierZmienna { get; set; }

    public decimal? ZaEStawkaKofeina { get; set; }

    public byte? ZaEJmDzielWzwm { get; set; }

    public string? ZaEGuid { get; set; }

    public virtual ZamNag ZaEGidnumerNavigation { get; set; } = null!;

    public virtual ZaEopisy? ZaEopisy { get; set; }
}
