using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PicoKonfig
{
    public int PcKPicoId { get; set; }

    public int? PcKMagNumer { get; set; }

    public int? PcKMagZwrNumer { get; set; }

    public int? PcKMagZamNumer { get; set; }

    public int? PcKCentrumId { get; set; }

    public int? PcKTssynchr { get; set; }

    public int? PcKTssynchrPtw { get; set; }

    public short PcKStan { get; set; }

    public short? PcKEtapSynchronizacji { get; set; }

    public string? PcKPicoSmtp { get; set; }

    public string PcKKatalogArchiwum { get; set; } = null!;

    public short? PcKKnGityp { get; set; }

    public int? PcKKnGinumer { get; set; }

    public byte? PcKExpKnt { get; set; }

    public byte? PcKAutoExpKnt { get; set; }

    public short? PcKKnGetyp { get; set; }

    public int? PcKKnGenumer { get; set; }

    public byte? PcKExpKntTyp { get; set; }

    public byte? PcKAutoExpKntTyp { get; set; }

    public byte? PcKExpKntPlatnosci { get; set; }

    public int? PcKTssynchrKnt { get; set; }

    public int? PcKTssynchrKntPtw { get; set; }

    public byte? PcKExpZalaczniki { get; set; }

    public byte? PcKAutoExpZalaczniki { get; set; }

    public byte? PcKAutoImport { get; set; }

    public byte? PcKAutoExport { get; set; }

    public string? PcKAutoSerwer { get; set; }

    public byte? PcKExpCennik { get; set; }

    public byte? PcKAutoExpCennik { get; set; }

    public short? PcKTwGtyp { get; set; }

    public int? PcKTwGnumer { get; set; }

    public byte? PcKExpCennikTyp { get; set; }

    public byte? PcKAutoExpCennikTyp { get; set; }

    public byte? PcKExpCennikStanyZerowe { get; set; }

    public byte? PcKAutoExpCennikStanyZerowe { get; set; }

    public byte? PcKCenaZakupu { get; set; }

    public short? PcKNrCeny { get; set; }

    public short? PcKIloscCenAutonomicznych { get; set; }

    public short? PcKNrCenyWzorcowej { get; set; }

    public short? PcKNrCenyDomyslnej { get; set; }

    public int? PcKTssynchrTwr { get; set; }

    public int? PcKTssynchrTwrPtw { get; set; }

    public byte? PcKExpPrm { get; set; }

    public short? PcKExpTwGtyp { get; set; }

    public int? PcKExpTwGnumer { get; set; }

    public short? PcKExpKnGtyp { get; set; }

    public int? PcKExpKnGnumer { get; set; }

    public byte? PcKExpPrmTyp { get; set; }

    public int? PcKTssynchrPrm { get; set; }

    public int? PcKTssynchrPrmPtw { get; set; }

    public short? PcKExpGrup { get; set; }

    public short? PcKAutoExpGrup { get; set; }

    public short? PcKExpGrupTyp { get; set; }

    public short? PcKAutoExpGrupTyp { get; set; }

    public int? PcKTssynchrGrup { get; set; }

    public int? PcKTssynchrGrupPtw { get; set; }

    public byte? PcKZamPotwierdzaj { get; set; }

    public int? PcKBlokady { get; set; }

    public byte PcKMminfo { get; set; }

    public int? PcKSeriaRak { get; set; }

    public short? PcKLogFlag { get; set; }

    public int? PcKIloscDniFapa { get; set; }

    public byte? PcKAs { get; set; }

    public string? PcKAsserwer { get; set; }

    public string? PcKAskomp { get; set; }

    public byte? PcKAstermin { get; set; }

    public int? PcKAsterminOd { get; set; }

    public int? PcKAsterminDo { get; set; }

    public int? PcKTssynchrKntO { get; set; }

    public string? PcKCertyfikat { get; set; }

    public short? PcKTyp { get; set; }

    public int? PcKTssynchrTwO { get; set; }

    public int? PcKTssynchrTwOptw { get; set; }

    public byte? PcKExpTwrOpisy { get; set; }

    public byte? PcKExpKntZobowiazania { get; set; }

    public short? PcKAktualizacjaPlanowSprDo { get; set; }

    public int? PcKTssynchrTwC { get; set; }

    public int? PcKTssynchrTwCptw { get; set; }

    public short? PcKOpiekunImpDok { get; set; }

    public byte? PcKExpKntOpisy { get; set; }

    public byte? PcKExpKntOsoby { get; set; }

    public int? PcKTssynchrKnO { get; set; }

    public int? PcKTssynchrKnOptw { get; set; }

    public int? PcKTssynchrKnS { get; set; }

    public int? PcKTssynchrKnSptw { get; set; }

    public byte? PcKAutoWydanieWszystkichZasobow { get; set; }

    public short? PcKAutoPrzyjmijZaplate { get; set; }

    public int? PcKSerNumer { get; set; }

    public byte? PcKExpZanRealizacje { get; set; }

    public string? PcKRok { get; set; }

    public string? PcKIMallId { get; set; }

    public string? PcKIMallHaslo { get; set; }

    public byte? PcKIMallWspolpraca { get; set; }

    public string? PcKIMallSerwer { get; set; }

    public string? PcKIMallHash { get; set; }

    public string? PcKGuid { get; set; }

    public byte? PcKExpTwrZamienniki { get; set; }

    public string? PcKWaluta { get; set; }

    public short? PcKNrKursu { get; set; }

    public byte? PcKKursRecznie { get; set; }

    public int? PcKISklepId { get; set; }

    public string? PcKISklepHash { get; set; }

    public byte? PcKSsl { get; set; }

    public byte? PcKWymPotwWizyt { get; set; }

    public byte? PcKImpKntDodawanie { get; set; }

    public byte? PcKImpKntEdycja { get; set; }

    public int? PcKImpKntRodzajId { get; set; }

    public short? PcKTwGityp { get; set; }

    public int? PcKTwGinumer { get; set; }

    public short? PcKTwGetyp { get; set; }

    public int? PcKTwGenumer { get; set; }

    public int? PcKImpTwrRodzajId { get; set; }

    public short? PcKMobSprzedstDniOstrzezenie { get; set; }

    public decimal? PcKMobSprzedstKwota { get; set; }

    public short? PcKMobSprzedstDniBlokada { get; set; }

    public byte? PcKMobSeksportZamwBuforze { get; set; }

    public byte? PcKSposobPotwZamOfe { get; set; }

    public byte? PcKImpKntWymagajPotwierdzenia { get; set; }

    public byte? PcKExpUwzgledniajRezerwacje { get; set; }

    public byte? PcKImpKntWymagajPotwierdzeniaDodania { get; set; }

    public string? PcKSql { get; set; }

    public byte? PcKImpZamXml { get; set; }

    public byte? PcKMapKntNip { get; set; }

    public byte? PcKMapKntEmail { get; set; }

    public byte? PcKMapAktualizujDane { get; set; }

    public byte? PcKZatwierdzanieZamPoPrzekrLimitu { get; set; }

    public byte? PcKSposobWyszukiwania { get; set; }

    public short? PcKKartyp { get; set; }

    public int? PcKKarfirma { get; set; }

    public int? PcKKarnumer { get; set; }

    public short? PcKKarlp { get; set; }

    public int? PcKDniPrzedData { get; set; }

    public byte? PcKFaDoPapoTerminie { get; set; }

    public byte? PcKAutoZamykanieOkna { get; set; }

    public byte? PcKPrzeliczajBezPytania { get; set; }

    public byte? PcKMinimalizacja { get; set; }

    public byte? PcKBlokadawieleDok { get; set; }

    public byte? PcKUjemnaKasaAutoryzacja { get; set; }

    public byte? PcKGenerujPwnaBraki { get; set; }

    public byte? PcKSprWroznychWalutach { get; set; }

    public int? PcKTszmianyGrupyEksportuTwr { get; set; }

    public int? PcKTszmianyGrupyEksportuKnt { get; set; }

    public byte? PcKPodpLogowania { get; set; }

    public string? PcKPosagentKod { get; set; }

    public string? PcKPosagentHost { get; set; }

    public string? PcKPosagentPort { get; set; }

    public string? PcKPosagentGuid { get; set; }

    public string? PcKPosagentProfil { get; set; }

    public byte? PcKAutomatyczneMmw { get; set; }

    public int? PcKIloscPozycji { get; set; }

    public byte? PcKAutomatycznePwrw { get; set; }

    public byte? PcKLogowanieKarta { get; set; }

    public int? PcKMdNnumer { get; set; }

    public int? PcKTssynchrBin { get; set; }

    public int? PcKTssynchrBinPtw { get; set; }

    public string? PcKWszystkoPlserwer { get; set; }

    public string? PcKWszystkoPllogin { get; set; }

    public string? PcKWszystkoPlaccessToken { get; set; }

    public string? PcKWszystkoPlrefreshToken { get; set; }

    public string? PcKWszystkoPldc { get; set; }

    public byte? PcKExpTylkoCeny { get; set; }

    public byte? PcKExpAktStanOferty { get; set; }

    public byte? PcKExpPublikujOferty { get; set; }

    public byte? PcKLimitKrObs { get; set; }

    public short? PcKLimitKrMaksCzas { get; set; }

    public byte? PcKLimitKrPrez { get; set; }

    public byte? PcKKopiujIloscZzamSpr { get; set; }

    public byte? PcKExpStanZamZamk { get; set; }

    public byte? PcKInwObs { get; set; }

    public byte? PcKInwOstDodawTwrNaDok { get; set; }

    public byte? PcKAutomatyczneNaliczaniePp { get; set; }

    public virtual ICollection<PicoCenniki> PicoCennikis { get; set; } = new List<PicoCenniki>();

    public virtual ICollection<PicoKntRodzaje> PicoKntRodzajes { get; set; } = new List<PicoKntRodzaje>();

    public virtual ICollection<PicoKontrahenci> PicoKontrahencis { get; set; } = new List<PicoKontrahenci>();

    public virtual ICollection<PicoLog> PicoLogs { get; set; } = new List<PicoLog>();

    public virtual ICollection<PicoRelacje> PicoRelacjes { get; set; } = new List<PicoRelacje>();

    public virtual ICollection<PicoSposobyDst> PicoSposobyDsts { get; set; } = new List<PicoSposobyDst>();

    public virtual ICollection<PicoStanowiska> PicoStanowiskas { get; set; } = new List<PicoStanowiska>();

    public virtual ICollection<PicoSzybkaSprzedaz> PicoSzybkaSprzedazs { get; set; } = new List<PicoSzybkaSprzedaz>();

    public virtual ICollection<PicoTimestamp> PicoTimestamps { get; set; } = new List<PicoTimestamp>();

    public virtual ICollection<PicoUlubioneTwr> PicoUlubioneTwrs { get; set; } = new List<PicoUlubioneTwr>();

    public virtual ICollection<PicoUsuniete> PicoUsunietes { get; set; } = new List<PicoUsuniete>();

    public virtual ICollection<PicoWaluty> PicoWaluties { get; set; } = new List<PicoWaluty>();
}
