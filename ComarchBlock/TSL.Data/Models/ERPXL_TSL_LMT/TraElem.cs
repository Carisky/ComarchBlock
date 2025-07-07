using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TraElem
{
    public short? TrEGidtyp { get; set; }

    public int? TrEGidfirma { get; set; }

    public int TrEGidnumer { get; set; }

    public short TrEGidlp { get; set; }

    public short? TrEPozycja { get; set; }

    public short? TrETwrTyp { get; set; }

    public int? TrETwrFirma { get; set; }

    public int? TrETwrNumer { get; set; }

    public short? TrETwrLp { get; set; }

    public string? TrETwrNazwa { get; set; }

    public string? TrETwrKod { get; set; }

    public byte? TrETypTwr { get; set; }

    public short? TrEKntTyp { get; set; }

    public int? TrEKntFirma { get; set; }

    public int? TrEKntNumer { get; set; }

    public short? TrEKntLp { get; set; }

    public short? TrEAkwTyp { get; set; }

    public int? TrEAkwFirma { get; set; }

    public int? TrEAkwNumer { get; set; }

    public short? TrEAkwLp { get; set; }

    public int? TrETrnTstamp { get; set; }

    public decimal? TrEPunkty { get; set; }

    public decimal? TrEIlosc { get; set; }

    public byte? TrEJmFormat { get; set; }

    public string? TrEJmZ { get; set; }

    public byte? TrEJmFormatZ { get; set; }

    public byte? TrETypJm { get; set; }

    public decimal? TrEPrzeliczM { get; set; }

    public decimal? TrEPrzeliczL { get; set; }

    public string? TrEGrupaPod { get; set; }

    public decimal? TrEStawkaPod { get; set; }

    public byte? TrEFlagaVat { get; set; }

    public decimal? TrEZrodlowa { get; set; }

    public decimal? TrEAkcyza { get; set; }

    public string? TrEWaluta { get; set; }

    public short? TrENrKursu { get; set; }

    public decimal? TrEKursM { get; set; }

    public decimal? TrEKursL { get; set; }

    public decimal? TrEPoczatkowa { get; set; }

    public string? TrEFlagaNb { get; set; }

    public decimal? TrERabat { get; set; }

    public decimal? TrEWartoscPoRabacie { get; set; }

    public decimal? TrEKsiegowaNetto { get; set; }

    public decimal? TrEKsiegowaBrutto { get; set; }

    public decimal? TrERzeczywistaNetto { get; set; }

    public decimal? TrEKosztKsiegowy { get; set; }

    public decimal? TrEKosztRzeczywisty { get; set; }

    public byte? TrEProgTyp { get; set; }

    public decimal? TrEProg { get; set; }

    public byte? TrEUpustTyp { get; set; }

    public decimal? TrEUpust { get; set; }

    public decimal? TrEUpustKnt { get; set; }

    public byte? TrEUpustKntTyp { get; set; }

    public decimal? TrEIloscDpprzed { get; set; }

    public decimal? TrEKsiegowyDpprzed { get; set; }

    public short? TrEZlcTyp { get; set; }

    public int? TrEZlcFirma { get; set; }

    public int? TrEZlcNumer { get; set; }

    public short? TrEZlcLp { get; set; }

    public short? TrERecTyp { get; set; }

    public int? TrERecFirma { get; set; }

    public int? TrERecNumer { get; set; }

    public short? TrERecLp { get; set; }

    public decimal? TrECena { get; set; }

    public byte? TrERownanie { get; set; }

    public byte? TrEOdKsiegowych { get; set; }

    public decimal? TrERzeczywistyDpprzed { get; set; }

    public string? TrEPcn { get; set; }

    public byte? TrEPrecyzjaCeny { get; set; }

    public short? TrEVatTyp { get; set; }

    public int? TrEVatFirma { get; set; }

    public int? TrEVatNumer { get; set; }

    public short? TrEVatLp { get; set; }

    public byte? TrEKosztVat { get; set; }

    public byte? TrEKosztNetto { get; set; }

    public short? TrELicencja { get; set; }

    public string? TrEKrajPoch { get; set; }

    public decimal? TrERabatPromocyjny { get; set; }

    public decimal? TrERabatKorekta { get; set; }

    public int? TrEPromocje { get; set; }

    public short? TrEZstTyp { get; set; }

    public int? TrEZstFirma { get; set; }

    public int? TrEZstNumer { get; set; }

    public short? TrEZstLp { get; set; }

    public byte? TrEPrecyzjaCenyPocz { get; set; }

    public byte? TrEZwroconoCalaIlosc { get; set; }

    public short? TrERodzajCenyBazowej { get; set; }

    public decimal? TrEKosztBazowy { get; set; }

    public decimal? TrEWartoscBazowa { get; set; }

    public short? TrECenaSpr { get; set; }

    public decimal? TrECenaPoRabacie { get; set; }

    public short? TrECchTyp { get; set; }

    public int? TrECchNumer { get; set; }

    public string? TrECecha { get; set; }

    public decimal? TrEKgojednostkowe { get; set; }

    public decimal? TrEIloscMin { get; set; }

    public decimal? TrEIloscMax { get; set; }

    public int? TrEPakietId { get; set; }

    public short? TrEGratis { get; set; }

    public int? TrEPromocjaProgId { get; set; }

    public byte? TrEFormatkaCyr { get; set; }

    public short? TrEZlom { get; set; }

    public decimal? TrEIloscPrzedKorekta { get; set; }

    public decimal? TrECenaPrzedKorekta { get; set; }

    public decimal? TrEWartoscPrzedKorekta { get; set; }

    public string? TrEGrupaPodPrzedKorekta { get; set; }

    public decimal? TrEStawkaPodPrzedKorekta { get; set; }

    public byte? TrEFlagaVatPrzedKorekta { get; set; }

    public decimal? TrEZrodlowaPrzedKorekta { get; set; }

    public decimal? TrEAkcyzaPrzedKorekta { get; set; }

    public string? TrEPrzyczynaKorekty { get; set; }

    public byte? TrEKatDatyOp { get; set; }

    public int? TrERodzajKosztu { get; set; }

    public int? TrEPakietTwgNumer { get; set; }

    public short? TrEPakietTwgTyp { get; set; }

    public decimal? TrERabatOpeGen { get; set; }

    public byte? TrEPakietWymaganaPoz { get; set; }

    public int? TrESentId { get; set; }

    public short? TrENagroda { get; set; }

    public int? TrEOperatorPos { get; set; }

    public int? TrESentElemId { get; set; }

    public string? TrEGuid { get; set; }

    public byte? TrEOplataSpozFlaga { get; set; }

    public decimal? TrEStawkaCukierStala { get; set; }

    public decimal? TrEStawkaCukierZmienna { get; set; }

    public decimal? TrEStawkaKofeina { get; set; }

    public byte? TrEBon { get; set; }

    public virtual ICollection<RetroStrukturaRabatu> RetroStrukturaRabatus { get; set; } = new List<RetroStrukturaRabatu>();

    public virtual TraNag TrEGidnumerNavigation { get; set; } = null!;

    public virtual ICollection<TraSelem> TraSelems { get; set; } = new List<TraSelem>();

    public virtual TreOpisy? TreOpisy { get; set; }
}
