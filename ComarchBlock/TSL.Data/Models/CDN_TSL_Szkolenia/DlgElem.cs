using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DlgElem
{
    public int DleDleid { get; set; }

    public int DleDlnid { get; set; }

    public short DleRodzajEtapu { get; set; }

    public int? DleKatId { get; set; }

    public string? DleKategoria { get; set; }

    public DateTime? DleDataOd { get; set; }

    public DateTime? DleDataDo { get; set; }

    public DateTime? DleGodzinaOd { get; set; }

    public DateTime? DleGodzinaDo { get; set; }

    public string? DleKraj { get; set; }

    public decimal? DleStawkaDiety { get; set; }

    public short? DleStawkaTyp { get; set; }

    public short DleWyplataZaliczkiSys { get; set; }

    public short DleRozliczenieSys { get; set; }

    public short DleDataPoniesieniaKosztu { get; set; }

    public short DleKursRozliczenia { get; set; }

    public DateTime? DleDataDok { get; set; }

    public DateTime? DleDataKur { get; set; }

    public string DleWaluta { get; set; } = null!;

    public int DleKursNumer { get; set; }

    public decimal DleKursL { get; set; }

    public decimal DleKursM { get; set; }

    public decimal DleKwotaSys { get; set; }

    public decimal DleKwotaWal { get; set; }

    public DateTime? DleKsiDataDok { get; set; }

    public DateTime? DleKsiDataKur { get; set; }

    public string? DleKsiWaluta { get; set; }

    public int? DleKsiKursNumer { get; set; }

    public decimal? DleKsiKursL { get; set; }

    public decimal? DleKsiKursM { get; set; }

    public decimal? DleKsiKwotaSys { get; set; }

    public decimal? DleKsiKwotaWal { get; set; }

    public DateTime? DleTerminPlatnosci { get; set; }

    public int? DleFplId { get; set; }

    public string? DleZapisKbBraAkronim { get; set; }

    public short? DleGenerujPlatnoscKb { get; set; }

    public short? DleGenerujZapisKb { get; set; }

    public short DleSumujWyjazdPrzyjazd { get; set; }

    public DateTime? DleIloscGodzinWyjazd { get; set; }

    public DateTime? DleIloscGodzinPrzyjazd { get; set; }

    public DateTime? DleIloscGodzinDelegacji { get; set; }

    public decimal? DleDietyIlosc { get; set; }

    public decimal? DleDietyKwota { get; set; }

    public decimal? DleDietyKwotaSys { get; set; }

    public decimal? DleKsiDietyKwota { get; set; }

    public decimal? DleKsiDietyKwotaSys { get; set; }

    public decimal? DleRazemDiety { get; set; }

    public decimal? DleRazemDietySys { get; set; }

    public decimal? DleKsiRazemDiety { get; set; }

    public decimal? DleKsiRazemDietySys { get; set; }

    public int? DleRyczaltDojazdyIlosc { get; set; }

    public decimal? DleRyczaltDojazdyKwota { get; set; }

    public decimal? DleRyczaltDojazdyKwotaSys { get; set; }

    public decimal? DleKsiRyczaltDojazdyKwota { get; set; }

    public decimal? DleKsiRyczaltDojazdyKwotaSys { get; set; }

    public int? DleRyczaltNoclegiIlosc { get; set; }

    public decimal? DleRyczaltNoclegiKwota { get; set; }

    public decimal? DleRyczaltNoclegiKwotaSys { get; set; }

    public decimal? DleKsiRyczaltNoclegiKwota { get; set; }

    public decimal? DleKsiRyczaltNoclegiKwotaSys { get; set; }

    public short? DleRyczaltNoclegiAuto { get; set; }

    public short? DleRyczaltDojazdyAuto { get; set; }

    public short? DleRyczaltDojazdyDworzecAuto { get; set; }

    public decimal? DleRyczaltDojazdyDworzecIlosc { get; set; }

    public decimal? DleRyczaltDojazdyDworzecKwota { get; set; }

    public decimal? DleRyczaltDojazdyDworzecKwotaSys { get; set; }

    public decimal? DleKsiRyczaltDojazdyDworzecKwota { get; set; }

    public decimal? DleKsiRyczaltDojazdyDworzecKwotaSys { get; set; }

    public short? DleRyczaltPobytSzpitalAuto { get; set; }

    public int? DleRyczaltPobytSzpitalIlosc { get; set; }

    public decimal? DleRyczaltPobytSzpitalKwota { get; set; }

    public decimal? DleRyczaltPobytSzpitalKwotaSys { get; set; }

    public decimal? DleKsiRyczaltPobytSzpitalKwota { get; set; }

    public decimal? DleKsiRyczaltPobytSzpitalKwotaSys { get; set; }

    public string? DleNumerRejestracyjny { get; set; }

    public short? DleTypPojazdu { get; set; }

    public decimal? DlePojazdStawkaZaKilometr { get; set; }

    public int? DlePojazdIloscKilometrow { get; set; }

    public decimal? DlePojazdKoszt { get; set; }

    public decimal? DlePojazdKosztSys { get; set; }

    public decimal? DleKsiPojazdKoszt { get; set; }

    public decimal? DleKsiPojazdKosztSys { get; set; }

    public int? DleIloscSniadan { get; set; }

    public int? DleIloscObiadow { get; set; }

    public int? DleIloscKolacji { get; set; }

    public decimal? DleRazemRyczaltDojazdy { get; set; }

    public decimal? DleRazemRyczaltDojazdySys { get; set; }

    public decimal? DleRazemRyczaltNoclegi { get; set; }

    public decimal? DleRazemRyczaltNoclegiSys { get; set; }

    public decimal? DleRazemRyczaltDiety { get; set; }

    public decimal? DleRazemRyczaltDietySys { get; set; }

    public decimal? DleRazemInneWydatki { get; set; }

    public decimal? DleRazemInneWydatkiSys { get; set; }

    public decimal? DleRazemWydatki { get; set; }

    public decimal? DleRazemWydatkiSys { get; set; }

    public decimal? DleRazemZaliczka { get; set; }

    public decimal? DleRazemZaliczkaSys { get; set; }

    public decimal? DleRazemWydatkiBilety { get; set; }

    public decimal? DleRazemWydatkiNoclegi { get; set; }

    public decimal? DleRazemWydatkiInne { get; set; }

    public int? DleRazemWydatkiBiletyIlosc { get; set; }

    public int? DleRazemWydatkiNoclegiIlosc { get; set; }

    public int? DleRazemWydatkiInneIlosc { get; set; }

    public decimal? DleRozliczono { get; set; }

    public decimal? DlePozostaje { get; set; }

    public decimal? DleKsiRazemRyczaltDojazdy { get; set; }

    public decimal? DleKsiRazemRyczaltDojazdySys { get; set; }

    public decimal? DleKsiRazemRyczaltNoclegiSys { get; set; }

    public decimal? DleKsiRazemRyczaltNoclegi { get; set; }

    public decimal? DleKsiRazemRyczaltDietySys { get; set; }

    public decimal? DleKsiRazemRyczaltDiety { get; set; }

    public decimal? DleKsiRazemInneWydatkiSys { get; set; }

    public decimal? DleKsiRazemInneWydatki { get; set; }

    public decimal? DleKsiRazemWydatki { get; set; }

    public decimal? DleKsiRazemWydatkiSys { get; set; }

    public decimal? DleKsiRazemZaliczkaSys { get; set; }

    public decimal? DleKsiRazemZaliczka { get; set; }

    public decimal? DleRoznicaKursowa { get; set; }

    public decimal? DleKwotaRozliczenia { get; set; }

    public decimal? DleKwotaRozliczeniaSys { get; set; }

    public decimal? DleKsiKwotaRozliczenia { get; set; }

    public decimal? DleKsiKwotaRozliczeniaSys { get; set; }

    public string? DleOpis { get; set; }

    public short DleWymagaPrzeliczenia { get; set; }

    public int DleZrodlo { get; set; }

    public virtual DlgNag DleDln { get; set; } = null!;

    public virtual ICollection<DlgDokumenty> DlgDokumenties { get; set; } = new List<DlgDokumenty>();

    public virtual ICollection<DlgTrasy> DlgTrasies { get; set; } = new List<DlgTrasy>();

    public virtual ICollection<DlgZaliczki> DlgZaliczkis { get; set; } = new List<DlgZaliczki>();
}
