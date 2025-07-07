using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TraNag
{
    public int TrNTrNid { get; set; }

    public int? TrNRelTrNid { get; set; }

    public byte? TrNFvmarza { get; set; }

    public byte? TrNFvmarzaRodzaj { get; set; }

    public int? TrNDdfId { get; set; }

    public int TrNTypDokumentu { get; set; }

    public int? TrNZwrId { get; set; }

    public int? TrNZwrIdWzkk { get; set; }

    public int? TrNFaId { get; set; }

    public int TrNNumerNr { get; set; }

    public string TrNNumerString { get; set; } = null!;

    public string? TrNNumerPelny { get; set; }

    public short TrNBufor { get; set; }

    public int TrNAnulowany { get; set; }

    public int? TrNVaNid { get; set; }

    public int? TrNRycId { get; set; }

    public int? TrNKprid { get; set; }

    public DateTime TrNDataDok { get; set; }

    public DateTime TrNDataWys { get; set; }

    public DateTime TrNDataOpe { get; set; }

    public string TrNNumerObcy { get; set; } = null!;

    public DateTime TrNDataKur { get; set; }

    public string TrNNumerPelnyPrw { get; set; } = null!;

    public byte TrNTaxFreePotwierdzony { get; set; }

    public byte TrNKorekta { get; set; }

    public byte TrNFiskalna { get; set; }

    public int? TrNFiskalnaErr { get; set; }

    public string? TrNStatusString { get; set; }

    public int TrNStatusInt { get; set; }

    public decimal? TrNRabatPromocyjny { get; set; }

    public decimal? TrNRabatKorekta { get; set; }

    public byte TrNDetal { get; set; }

    public int TrNRodzaj { get; set; }

    public short? TrNPodmiotTyp { get; set; }

    public int? TrNPodId { get; set; }

    public string TrNPodNazwa1 { get; set; } = null!;

    public string TrNPodNazwa2 { get; set; } = null!;

    public string TrNPodNazwa3 { get; set; } = null!;

    public string TrNPodKraj { get; set; } = null!;

    public string TrNPodWojewodztwo { get; set; } = null!;

    public string TrNPodPowiat { get; set; } = null!;

    public string TrNPodGmina { get; set; } = null!;

    public string TrNPodUlica { get; set; } = null!;

    public string TrNPodNrDomu { get; set; } = null!;

    public string TrNPodNrLokalu { get; set; } = null!;

    public string TrNPodMiasto { get; set; } = null!;

    public string TrNPodKodPocztowy { get; set; } = null!;

    public string TrNPodPoczta { get; set; } = null!;

    public string TrNPodAdres2 { get; set; } = null!;

    public string TrNPodNipKraj { get; set; } = null!;

    public string TrNPodNipE { get; set; } = null!;

    public string TrNPodmiotGln { get; set; } = null!;

    public byte TrNFinalny { get; set; }

    public byte TrNPodatekVat { get; set; }

    public string TrNPesel { get; set; } = null!;

    public byte TrNExport { get; set; }

    public byte TrNZwolnionyZakcyzy { get; set; }

    public short? TrNOdbiorcaTyp { get; set; }

    public int? TrNOdbId { get; set; }

    public string TrNOdbNazwa1 { get; set; } = null!;

    public string TrNOdbNazwa2 { get; set; } = null!;

    public string TrNOdbNazwa3 { get; set; } = null!;

    public string TrNOdbKraj { get; set; } = null!;

    public string TrNOdbWojewodztwo { get; set; } = null!;

    public string TrNOdbPowiat { get; set; } = null!;

    public string TrNOdbGmina { get; set; } = null!;

    public string TrNOdbUlica { get; set; } = null!;

    public string TrNOdbNrDomu { get; set; } = null!;

    public string TrNOdbNrLokalu { get; set; } = null!;

    public string TrNOdbMiasto { get; set; } = null!;

    public string TrNOdbKodPocztowy { get; set; } = null!;

    public string TrNOdbPoczta { get; set; } = null!;

    public string TrNOdbAdres2 { get; set; } = null!;

    public string TrNOdbNipKraj { get; set; } = null!;

    public string TrNOdbNipE { get; set; } = null!;

    public string TrNOdbiorcaGln { get; set; } = null!;

    public short? TrNOdbiorcaDocTyp { get; set; }

    public int? TrNOdbDocId { get; set; }

    public string? TrNOdbTelefon { get; set; }

    public string? TrNOdbEmail { get; set; }

    public short? TrNPlatnikTyp { get; set; }

    public int? TrNPlatnikId { get; set; }

    public byte TrNFadokumentDostawy { get; set; }

    public byte TrNFinalnyWegiel { get; set; }

    public string TrNNrListuPrzewozowego { get; set; } = null!;

    public int TrNNrListuPrzewozowegoTypKuriera { get; set; }

    public int? TrNKatId { get; set; }

    public string TrNKategoria { get; set; } = null!;

    public int? TrNFplId { get; set; }

    public DateTime TrNTermin { get; set; }

    public DateTime? TrNTerminZwrotuKaucji { get; set; }

    public decimal TrNRazemNetto { get; set; }

    public decimal TrNRazemVat { get; set; }

    public decimal TrNRazemBrutto { get; set; }

    public decimal? TrNWartoscZakupu { get; set; }

    public decimal TrNRazemNettoWal { get; set; }

    public decimal TrNRazemVatwal { get; set; }

    public decimal TrNRazemBruttoWal { get; set; }

    public string TrNWaluta { get; set; } = null!;

    public int TrNKursNumer { get; set; }

    public decimal TrNKursL { get; set; }

    public decimal TrNKursM { get; set; }

    public byte TrNPlatElemWalSys { get; set; }

    public byte TrNVatDlaDokWal { get; set; }

    public byte TrNPlatKaucje { get; set; }

    public short? TrNPodmiotZalTyp { get; set; }

    public int? TrNPodZalId { get; set; }

    public short TrNBlokadaPlatnosci { get; set; }

    public int? TrNMagZrdId { get; set; }

    public int? TrNMagDocId { get; set; }

    public byte TrNTypNb { get; set; }

    public decimal TrNRabat { get; set; }

    public decimal TrNRabatWartosc { get; set; }

    public string TrNOdebral { get; set; } = null!;

    public string TrNOpis { get; set; } = null!;

    public byte? TrNZwroconoCalaIlosc { get; set; }

    public string TrNNotaKorPrzed { get; set; } = null!;

    public string TrNNotaKorPo { get; set; } = null!;

    public byte TrNTrStyp { get; set; }

    public int? TrNDekId { get; set; }

    public DateTime? TrNTsExport { get; set; }

    public string? TrNImportAppId { get; set; }

    public string? TrNImportRowId { get; set; }

    public int? TrNOpeZalId { get; set; }

    public int? TrNStaZalId { get; set; }

    public DateTime TrNTsZal { get; set; }

    public int? TrNOpeModId { get; set; }

    public int? TrNStaModId { get; set; }

    public DateTime TrNTsMod { get; set; }

    public string TrNOpeModKod { get; set; } = null!;

    public string TrNOpeModNazwisko { get; set; } = null!;

    public string TrNOpeZalKod { get; set; } = null!;

    public string TrNOpeZalNazwisko { get; set; } = null!;

    public short? TrNGidtyp { get; set; }

    public int? TrNGidfirma { get; set; }

    public int? TrNGidnumer { get; set; }

    public short? TrNGidlp { get; set; }

    public int? TrNESklepId { get; set; }

    public int? TrNNieOkreslonaWartoscKor { get; set; }

    public byte? TrNOffprawoDoFapa { get; set; }

    public byte? TrNOffprawoDoAnulowania { get; set; }

    public byte? TrNOffexportMag { get; set; }

    public byte TrNCentrala { get; set; }

    public string TrNKodTransakcji { get; set; } = null!;

    public int? TrNIsNid { get; set; }

    public DateTime? TrNDataTransportu { get; set; }

    public string TrNKodKraju { get; set; } = null!;

    public int? TrNDabId { get; set; }

    public DateTime? TrNDataEfaktura { get; set; }

    public string? TrNOpeWysylajacy { get; set; }

    public string? TrNEfakturaGuid { get; set; }

    public DateTime? TrNDataPtwTaxFree { get; set; }

    public int? TrNPreDekId { get; set; }

    public int TrNTrybNettoVat { get; set; }

    public string? TrNAkcyzaMiejsceOdbioru { get; set; }

    public string? TrNAkcyzaMiejsceWydania { get; set; }

    public DateTime? TrNAkcyzaDataRozpoczeciaPrzem { get; set; }

    public DateTime? TrNAkcyzaDataOdbioruOd { get; set; }

    public DateTime? TrNAkcyzaDataOdbioruDo { get; set; }

    public short? TrNSrw { get; set; }

    public int TrNParodzajKor { get; set; }

    public byte TrNMetodaKasowa { get; set; }

    public string TrNKorektaZtytulu { get; set; } = null!;

    public byte TrNEdycjaTabelkiVat { get; set; }

    public byte TrNPlatnoscNaWz { get; set; }

    public int TrNBzpId { get; set; }

    public byte TrNRezerwacjaWew { get; set; }

    public byte TrNPafaczesciowe { get; set; }

    public byte TrNAktualizacjaCenyZakKor { get; set; }

    public byte TrNStawkaNpoo { get; set; }

    public decimal TrNWartoscOo { get; set; }

    public int TrNAwizoId { get; set; }

    public int TrNDokMosmmid { get; set; }

    public int? TrNZakId { get; set; }

    public int TrNPunktyZam { get; set; }

    public int TrNPunktyZap { get; set; }

    public DateTime? TrNWeryfikacjaVatczynnyData { get; set; }

    public int? TrNWeryfikacjaVatczynnyWartosc { get; set; }

    public int TrnSent { get; set; }

    public int TrnDokumentDostawy { get; set; }

    public int? TrNPcid { get; set; }

    public int? TrNPcjsid { get; set; }

    public int? TrNESklepZrodlo { get; set; }

    public byte? TrNESklepRodzajDokumentu { get; set; }

    public string? TrNESklepFormaPlatnosci { get; set; }

    public byte? TrNESklepStatusPlatnosci { get; set; }

    public string? TrNESklepUwagiKlienta { get; set; }

    public short? TrNESklepSposobDostawyTyp { get; set; }

    public string? TrNESklepSposobDostawyNazwa { get; set; }

    public short? TrNESklepStatusDostawy { get; set; }

    public int? TrNESklepPunktOdbioruOsobistegoId { get; set; }

    public int? TrNESklepPunktOdbioruOsobistegoIdeSklep { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoNazwa1 { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoNazwa2 { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoKrajIso { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoUlica { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoWojewodztwo { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoNrBudynku { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoNrLokalu { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoMiasto { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoKodPocztowy { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoTelefon { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoGsm { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoEmail { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoApi { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoSzerokosc { get; set; }

    public string? TrNESklepPunktOdbioruOsobistegoDlugosc { get; set; }

    public string? TrNESklepKodPaczkomatuPodst { get; set; }

    public string? TrNESklepPaczkomatKodPaczki { get; set; }

    public string? TrNESklepPaczkomatPodstMiasto { get; set; }

    public string? TrNESklepPaczkomatPodstKodPocztowy { get; set; }

    public string? TrNESklepPaczkomatPodstUlica { get; set; }

    public string? TrNESklepPaczkomatPodstUlicaNr { get; set; }

    public string? TrNESklepKodPaczkomatuRezerw { get; set; }

    public string? TrNESklepPaczkomatRezerwMiasto { get; set; }

    public string? TrNESklepPaczkomatRezerwKodPocztowy { get; set; }

    public string? TrNESklepPaczkomatRezerwUlica { get; set; }

    public string? TrNESklepPaczkomatRezerwUlicaNr { get; set; }

    public int? TrNOpeZatwId { get; set; }

    public DateTime? TrNTsZatw { get; set; }

    public int? TrNOpeWydrId { get; set; }

    public DateTime? TrNTsWydr { get; set; }

    public string TrNOpeZatwKod { get; set; } = null!;

    public string TrNOpeZatwNazwisko { get; set; } = null!;

    public string TrNOpeWydrKod { get; set; } = null!;

    public string TrNOpeWydrNazwisko { get; set; } = null!;

    public int? TrNOpeEmailId { get; set; }

    public DateTime? TrNTsEmail { get; set; }

    public string TrNOpeEmailKod { get; set; } = null!;

    public string TrNOpeEmailNazwisko { get; set; } = null!;

    public string TrNDokumentTozsamosci { get; set; } = null!;

    public byte TrNUmowaWegiel { get; set; }

    public byte TrNSplitPay { get; set; }

    public decimal TrNWartoscSp { get; set; }

    public DateTime? TrNESklepDataDost { get; set; }

    public int TrNPlatnikRachunekLp { get; set; }

    public string TrNPlatnikRachunekNr { get; set; } = null!;

    public DateTime? TrNAwfWyslano { get; set; }

    public byte TrNNieNaliczajOplataCukrowa { get; set; }

    public byte TrNRozliczamPodatekWoss { get; set; }

    public int? TrNDnpId { get; set; }

    public byte? TrNApfinoStatFakt { get; set; }

    public byte? TrNApfinoStatWind { get; set; }

    public byte? TrNApfinoStatSync { get; set; }

    public string TrNNrKseF { get; set; } = null!;

    public byte TrNNieWysylajDokumentuDoKseF { get; set; }

    public short TrNKseFstatusId { get; set; }

    public string TrNKseFstatus { get; set; } = null!;

    public string? TrNKseFreferenceNumber { get; set; }

    public int? TrNKseFopeId { get; set; }

    public string? TrNKseFopeKod { get; set; }

    public string? TrNKseFopeNazwisko { get; set; }

    public int? TrNKseFupoopeId { get; set; }

    public string? TrNKseFupoopeKod { get; set; }

    public string? TrNKseFupoopeNazwisko { get; set; }

    public DateTime? TrNKseFdataWyslania { get; set; }

    public DateTime? TrNKseFdataPrzyjecia { get; set; }

    public DateTime? TrNKseFdataOdebraniaUpo { get; set; }

    public int? TrNKseFfplid { get; set; }

    public byte? TrNKseFtrybAwaryjny { get; set; }

    public short TrNKseFtypSrodowiska { get; set; }

    public byte TrNNieUwzglwedniajWewidencjiWegiel { get; set; }

    public string TrnWszystkoPlIdZamowienia { get; set; } = null!;

    public int TrnWszystkoPlSyncho { get; set; }

    public virtual ICollection<DokAtrybuty> DokAtrybuties { get; set; } = new List<DokAtrybuty>();

    public virtual ICollection<PodArkuszInwenNag> PodArkuszInwenNags { get; set; } = new List<PodArkuszInwenNag>();

    public virtual PodmiotyView? PodmiotyView { get; set; }

    public virtual PodmiotyView? PodmiotyViewNavigation { get; set; }

    public virtual DokDefinicje? TrNDdf { get; set; }

    public virtual FormyPlatnosci? TrNFpl { get; set; }

    public virtual Kategorie? TrNKat { get; set; }

    public virtual Magazyny? TrNMagDoc { get; set; }

    public virtual Magazyny? TrNMagZrd { get; set; }

    public virtual Pieczatki? TrNPc { get; set; }

    public virtual PieczatkiJ? TrNPcjs { get; set; }

    public virtual ICollection<TraElemKorZbiorcza> TraElemKorZbiorczas { get; set; } = new List<TraElemKorZbiorcza>();

    public virtual ICollection<TraElem> TraElems { get; set; } = new List<TraElem>();

    public virtual ICollection<TraFakZaliczkowe> TraFakZaliczkowes { get; set; } = new List<TraFakZaliczkowe>();

    public virtual TraNagTsmodEsklep? TraNagTsmodEsklep { get; set; }

    public virtual ICollection<TraVat> TraVats { get; set; } = new List<TraVat>();

    public virtual ICollection<TraeSklepAukcje> TraeSklepAukcjes { get; set; } = new List<TraeSklepAukcje>();
}
