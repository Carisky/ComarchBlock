using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Kontrahenci
{
    public int KntKntId { get; set; }

    public short? KntPodmiotTyp { get; set; }

    public string KntKod { get; set; } = null!;

    public string KntGln { get; set; } = null!;

    public string KntIdSisc { get; set; } = null!;

    public string KntEan { get; set; } = null!;

    public string KntGrupa { get; set; } = null!;

    public string KntNazwa1 { get; set; } = null!;

    public string KntNazwa2 { get; set; } = null!;

    public string KntNazwa3 { get; set; } = null!;

    public string KntKraj { get; set; } = null!;

    public string KntWojewodztwo { get; set; } = null!;

    public string KntPowiat { get; set; } = null!;

    public string KntGmina { get; set; } = null!;

    public string KntUlica { get; set; } = null!;

    public string KntNrDomu { get; set; } = null!;

    public string KntNrLokalu { get; set; } = null!;

    public string KntMiasto { get; set; } = null!;

    public string KntKodPocztowy { get; set; } = null!;

    public string KntPoczta { get; set; } = null!;

    public string KntAdres2 { get; set; } = null!;

    public string KntNipKraj { get; set; } = null!;

    public string KntNipE { get; set; } = null!;

    public string KntNip { get; set; } = null!;

    public string KntNipPelny { get; set; } = null!;

    public string KntRegon { get; set; } = null!;

    public string KntPesel { get; set; } = null!;

    public string KntTelefon1 { get; set; } = null!;

    public string KntTelefon2 { get; set; } = null!;

    public string KntTelefonSms { get; set; } = null!;

    public string KntFax { get; set; } = null!;

    public string KntEmail { get; set; } = null!;

    public string KntUrl { get; set; } = null!;

    public string KntKrajIso { get; set; } = null!;

    public string KntZezwolenie { get; set; } = null!;

    public string KntKodTransakcji { get; set; } = null!;

    public Guid? KntBazaBrGuid { get; set; }

    public int? KntBnaId { get; set; }

    public string KntRachunekNr { get; set; } = null!;

    public short KntIban { get; set; }

    public string? KntRachunekNr0 { get; set; }

    public string KntOsTytul { get; set; } = null!;

    public byte KntOsPlec { get; set; }

    public string KntOsNazwisko { get; set; } = null!;

    public string KntOsKraj { get; set; } = null!;

    public string KntOsWojewodztwo { get; set; } = null!;

    public string KntOsPowiat { get; set; } = null!;

    public string KntOsGmina { get; set; } = null!;

    public string KntOsUlica { get; set; } = null!;

    public string KntOsNrDomu { get; set; } = null!;

    public string KntOsNrLokalu { get; set; } = null!;

    public string KntOsMiasto { get; set; } = null!;

    public string KntOsKodPocztowy { get; set; } = null!;

    public string KntOsPoczta { get; set; } = null!;

    public string KntOsAdres2 { get; set; } = null!;

    public string KntOsTelefon { get; set; } = null!;

    public string KntOsGsm { get; set; } = null!;

    public string KntOsEmail { get; set; } = null!;

    public byte KntInformacje { get; set; }

    public decimal KntUpust { get; set; }

    public byte KntLimitFlag { get; set; }

    public decimal KntLimitKredytu { get; set; }

    public byte KntLimitPrzeterKredytFlag { get; set; }

    public decimal KntLimitPrzeterKredytWartosc { get; set; }

    public short KntCeny { get; set; }

    public int? KntFplId { get; set; }

    public short KntMaxZwloka { get; set; }

    public byte KntTerminPlat { get; set; }

    public short KntTermin { get; set; }

    public string KntKontoOdb { get; set; } = null!;

    public string KntKontoDost { get; set; } = null!;

    public int? KntKatId { get; set; }

    public int? KntKatZakId { get; set; }

    public byte KntBlokadaDok { get; set; }

    public string KntLimitKredytuWal { get; set; } = null!;

    public decimal KntLimitKredytuWykorzystany { get; set; }

    public byte KntNieRozliczac { get; set; }

    public byte KntPodatekVat { get; set; }

    public byte KntFinalny { get; set; }

    public byte KntFinalnyWegiel { get; set; }

    public byte KntExport { get; set; }

    public byte KntRodzaj { get; set; }

    public byte KntRodzajDostawca { get; set; }

    public byte KntRodzajOdbiorca { get; set; }

    public byte KntRodzajKonkurencja { get; set; }

    public byte KntRodzajPartner { get; set; }

    public byte KntRodzajPotencjalny { get; set; }

    public byte KntMedialny { get; set; }

    public byte KntMalyPod { get; set; }

    public byte KntRolnik { get; set; }

    public byte KntNieaktywny { get; set; }

    public byte KntChroniony { get; set; }

    public byte KntNieUwzglVatzd { get; set; }

    public string KntOpis { get; set; } = null!;

    public int? KntOdbiorcaId { get; set; }

    public short? KntOpiekunTyp { get; set; }

    public int? KntOpiekunId { get; set; }

    public short? KntOpiekunKsiegTyp { get; set; }

    public int? KntOpiekunKsiegId { get; set; }

    public byte? KntOpiekunKsiegDomyslny { get; set; }

    public short? KntOpiekunPiKtyp { get; set; }

    public int? KntOpiekunPiKid { get; set; }

    public byte? KntOpiekunPiKdomyslny { get; set; }

    public byte? KntOpiekunDomyslny { get; set; }

    public short KntTerminZwrotuKaucji { get; set; }

    public byte KntNaliczajPlatnosc { get; set; }

    public byte KntZakazDokumentowHaMag { get; set; }

    public byte KntZgodaNaEfaktury { get; set; }

    public byte? KntTypWymiany { get; set; }

    public byte KntPowiazanyUoV { get; set; }

    public byte KntMetodaKasowa { get; set; }

    public int? KntUwdid { get; set; }

    public string? KntUwdoddzial { get; set; }

    public string? KntUwdemail { get; set; }

    public byte KntAutoWindBlokadaSprzed { get; set; }

    public DateTime? KntTsExport { get; set; }

    public string? KntImportAppId { get; set; }

    public string? KntImportRowId { get; set; }

    public int? KntOpeZalId { get; set; }

    public int? KntStaZalId { get; set; }

    public DateTime KntTsZal { get; set; }

    public int? KntOpeModId { get; set; }

    public int? KntStaModId { get; set; }

    public DateTime KntTsMod { get; set; }

    public string KntOpeModKod { get; set; } = null!;

    public string KntOpeModNazwisko { get; set; } = null!;

    public string KntOpeZalKod { get; set; } = null!;

    public string KntOpeZalNazwisko { get; set; } = null!;

    public short? KntGidtyp { get; set; }

    public int? KntGidfirma { get; set; }

    public int? KntGidnumer { get; set; }

    public short? KntGidlp { get; set; }

    public int? KntESklepId { get; set; }

    public short KntESklepZrodlo { get; set; }

    public byte KntFczynnosci { get; set; }

    public byte KntFczesci { get; set; }

    public string? KntKorKraj { get; set; }

    public string? KntKorMiasto { get; set; }

    public string? KntKorKodPocztowy { get; set; }

    public string? KntKorPoczta { get; set; }

    public string? KntKorUlica { get; set; }

    public string? KntKorNrDomu { get; set; }

    public string? KntKorNrLokalu { get; set; }

    public byte KntNieNaliczajOdsetek { get; set; }

    public byte KntEsklep { get; set; }

    public byte KntZwolnionyZakcyzy { get; set; }

    public int? KntWindykacjaSchematId { get; set; }

    public int? KntWindykacjaOsobaId { get; set; }

    public string KntWindykacjaEmail { get; set; } = null!;

    public string KntWindykacjaTelefonSms { get; set; } = null!;

    public byte KntKomornik { get; set; }

    public string? KntKomornikOkreg { get; set; }

    public string? KntKomornikMiasto { get; set; }

    public string? KntKomornikRewir { get; set; }

    public int? KntNadId { get; set; }

    public int? KntGlId { get; set; }

    public string KntWaluta { get; set; } = null!;

    public byte KntAlgorytm { get; set; }

    public string? KntLoginComarchCloud { get; set; }

    public short? KntCjbtyp { get; set; }

    public int? KntCjbid { get; set; }

    public int KntLpAnonimizacji { get; set; }

    public DateTime? KntDataAnonimizacji { get; set; }

    public byte KntSplitPay { get; set; }

    public string KntDomena { get; set; } = null!;

    public string KntDokumentTozsamosci { get; set; } = null!;

    public byte KntUmowaWegiel { get; set; }

    public byte KntAwfZgoda { get; set; }

    public DateTime? KntAwfZgodaData { get; set; }

    public int KntAwfMonit { get; set; }

    public byte KntNieNaliczajOplataCukrowa { get; set; }

    public byte KntNieUwzglwedniajWewidencjiWegiel { get; set; }

    public byte KntNieWysylajDokumentuDoKseF { get; set; }

    public byte KntNieUwzgledniajPrzychWkasowymPit { get; set; }

    public byte? KntApfinoStatSync { get; set; }

    public DateTime? KntApfinoVerifDate { get; set; }

    public byte KntZamknMiesTyp { get; set; }

    public byte? KntZamknMiesDzien { get; set; }

    public DateTime? KntApfinoAmlNextEvalDate { get; set; }

    public virtual ICollection<DeklNag> DeklNags { get; set; } = new List<DeklNag>();

    public virtual ICollection<Kontrahenci> InverseKntCjb { get; set; } = new List<Kontrahenci>();

    public virtual ICollection<Kontrahenci> InverseKntNad { get; set; } = new List<Kontrahenci>();

    public virtual ICollection<Kontrahenci> InverseKntOdbiorca { get; set; } = new List<Kontrahenci>();

    public virtual BnkNazwy? KntBna { get; set; }

    public virtual Kontrahenci? KntCjb { get; set; }

    public virtual ICollection<KntEsklepy> KntEsklepies { get; set; } = new List<KntEsklepy>();

    public virtual ICollection<KntEsklepyPrzedstawiciele> KntEsklepyPrzedstawicieles { get; set; } = new List<KntEsklepyPrzedstawiciele>();

    public virtual FormyPlatnosci? KntFpl { get; set; }

    public virtual Kategorie? KntKat { get; set; }

    public virtual Kategorie? KntKatZak { get; set; }

    public virtual Kontrahenci? KntNad { get; set; }

    public virtual Kontrahenci? KntOdbiorca { get; set; }

    public virtual ICollection<KntOsoby> KntOsobies { get; set; } = new List<KntOsoby>();

    public virtual ICollection<KntWeryfRachHist> KntWeryfRachHists { get; set; } = new List<KntWeryfRachHist>();

    public virtual ICollection<KntWeryfStatHist> KntWeryfStatHists { get; set; } = new List<KntWeryfStatHist>();

    public virtual ICollection<KntZamknMy> KntZamknMies { get; set; } = new List<KntZamknMy>();

    public virtual Krd? Krd { get; set; }

    public virtual ICollection<OfertyDok> OfertyDoks { get; set; } = new List<OfertyDok>();

    public virtual ICollection<Towary> Towaries { get; set; } = new List<Towary>();

    public virtual ICollection<UmowyB2b> UmowyB2bs { get; set; } = new List<UmowyB2b>();
}
