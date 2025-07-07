using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymKontrahent
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KntDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KntDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KntDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int KntId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KntKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KntKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KntOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KntOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KntParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KntParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int KntRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] KntRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KntSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KntTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KntTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int KntZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SubWsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadDeleteId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadUpdateId { get; set; }

    /// <summary>
    /// Identyfikator miejscowości kontrahenta. Relacja do wymiaru WYM_Miejscowosc
    /// </summary>
    public int? KntMiejscowoscId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Obszar
    /// </summary>
    public int? KntObszarId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int? KntPracownikId { get; set; }

    /// <summary>
    /// Identyfikator sposobu dostawy. Relacja do wymiaru WYM_SposobDostawy
    /// </summary>
    public int? KntSposobDostawyId { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? FaktyAkw { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? FaktyDst { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? FaktyKntd { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? FaktyKntk { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? FaktyPlat { get; set; }

    /// <summary>
    /// Adres kontrahenta
    /// </summary>
    public string? KntAdres { get; set; }

    /// <summary>
    /// Akronim kontrahenta
    /// </summary>
    public string? KntAkronim { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KntAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KntAktualneOrgParId { get; set; }

    /// <summary>
    /// Informacja, czy kontrahent ma flagę &apos;Archiwalny&apos;. 0 - archiwalny, 1 - aktywny
    /// </summary>
    public int? KntAktywny { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? KntAkwDataPierwszejTranSpr { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? KntAkwizytor { get; set; }

    /// <summary>
    /// Identyfikator akwizytora
    /// </summary>
    public int? KntAkwizytorId { get; set; }

    /// <summary>
    /// Identyfikator akwizytora
    /// </summary>
    public string? KntAkwizytorOrgId { get; set; }

    /// <summary>
    /// Nazwa atrybutu1 pobranego z karty kontrahenta
    /// </summary>
    public string? KntAtrybut1Nazwa { get; set; }

    /// <summary>
    /// Wartość atrybutu1 pobranego z karty kontrahenta
    /// </summary>
    public string? KntAtrybut1Wartosc { get; set; }

    /// <summary>
    /// Nazwa atrybutu2 pobranego z karty kontrahenta
    /// </summary>
    public string? KntAtrybut2Nazwa { get; set; }

    /// <summary>
    /// Wartość atrybutu2 pobranego z karty kontrahenta
    /// </summary>
    public string? KntAtrybut2Wartosc { get; set; }

    /// <summary>
    /// Nazwa atrybutu3 pobranego z karty kontrahenta
    /// </summary>
    public string? KntAtrybut3Nazwa { get; set; }

    /// <summary>
    /// Wartość atrybutu3 pobranego z karty kontrahenta
    /// </summary>
    public string? KntAtrybut3Wartosc { get; set; }

    /// <summary>
    /// Branża kontrahenta
    /// </summary>
    public string? KntBranza { get; set; }

    /// <summary>
    /// Długość geograficzna klienta
    /// </summary>
    public decimal? KntDlugGeog { get; set; }

    /// <summary>
    /// Informacja, czy kontrahent jest dostawcą
    /// </summary>
    public string? KntDostawca { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? KntDstIloscRoz { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? KntDstMaxOp { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? KntDstMinOp { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? KntDstOdchStd { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? KntDstSok { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? KntDstSop { get; set; }

    /// <summary>
    /// Email kontrahenta
    /// </summary>
    public string? KntEmail { get; set; }

    /// <summary>
    /// Grupa cenowa
    /// </summary>
    public string? KntGrupaCenowa { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? KntKntDdataPierwszejTranSpr { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? KntKntdDataPierwszejTranZkp { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? KntKntIloscRoz { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? KntKntKdataPierwszejTranSpr { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? KntKntkDataPierwszejTranZkp { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? KntKntMaxOp { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? KntKntMinOp { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? KntKntOdchStd { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? KntKntSok { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? KntKntSop { get; set; }

    /// <summary>
    /// Kod pocztowy kontrahenta
    /// </summary>
    public string? KntKodPocztowy { get; set; }

    /// <summary>
    /// Limit kredytu kontrahenta
    /// </summary>
    public decimal? KntLimitKredytu { get; set; }

    /// <summary>
    /// Miejscowość kontrahenta
    /// </summary>
    public string? KntMiejscowosc { get; set; }

    /// <summary>
    /// Nazwa kontrahenta
    /// </summary>
    public string? KntNazwa { get; set; }

    /// <summary>
    /// NIP kontrahenta
    /// </summary>
    public string? KntNip { get; set; }

    /// <summary>
    /// Typ obiektu
    /// </summary>
    public int? KntObiTyp { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? KntOpis { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public string? KntOrgAtrId { get; set; }

    /// <summary>
    /// Rodzaj podmiotu
    /// </summary>
    public string? KntPodmiot { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? KntPoprzednikId { get; set; }

    /// <summary>
    /// Informacja, czy kontrahent jest producentem
    /// </summary>
    public int? KntProducent { get; set; }

    /// <summary>
    /// Rodzaj kontrahenta
    /// </summary>
    public string? KntRodzaj { get; set; }

    /// <summary>
    /// Rola partnera
    /// </summary>
    public string? KntRolaPartnera { get; set; }

    /// <summary>
    /// Szerokość geograficzna kontrahenta
    /// </summary>
    public decimal? KntSzerGeog { get; set; }

    /// <summary>
    /// Telefon kontrahenta
    /// </summary>
    public string? KntTelefon { get; set; }

    /// <summary>
    /// Termin płatności dla kontrahenta
    /// </summary>
    public int? KntTerminPlatnosci { get; set; }

    /// <summary>
    /// Adres www kontrahenta
    /// </summary>
    public string? KntUrl { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? KntWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? KntWymTyp { get; set; }

    /// <summary>
    /// Źródło kontrahenta
    /// </summary>
    public string? KntZrodlo { get; set; }

    /// <summary>
    /// Ważność kontrahenta
    /// </summary>
    public string? KntPriorytet { get; set; }

    /// <summary>
    /// Identyfikator centrali 
    /// </summary>
    public int? KntCentralaId { get; set; }

    /// <summary>
    /// Identyfikator centrali 
    /// </summary>
    public string? KntCentralaOrgId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Geografia
    /// </summary>
    public int? KntGeoid { get; set; }

    /// <summary>
    /// Domyślny termin płatności za zakupy dla kontrahenta
    /// </summary>
    public int? KntTerminPlatnosciZakup { get; set; }

    /// <summary>
    /// Informacja, czy kontrahent jest rolnikiem ryczałtowym
    /// </summary>
    public string? KntRolnikRyczalt { get; set; }

    /// <summary>
    /// Informacja, czy kontrahent jest płatnikiem VAT
    /// </summary>
    public string? KntPlatnikVat { get; set; }

    /// <summary>
    /// Informacja, czy kontrahent jest jednostką powiązaną
    /// </summary>
    public string? KntJednPowiazana { get; set; }

    /// <summary>
    /// Informacja czy kontrahent jest krajowy, czy z UE, czy spoza UE
    /// </summary>
    public string? KntExpoKraj { get; set; }

    /// <summary>
    /// Forma płatności za sprzedaż kontrahenta
    /// </summary>
    public string? KntFormaPlSprz { get; set; }

    /// <summary>
    /// Forma płatności za zakup kontrahenta
    /// </summary>
    public string? KntFormaPlZakup { get; set; }

    public string? KntLimitNieograniczony { get; set; }

    /// <summary>
    /// Numer karty lojalnościowej
    /// </summary>
    public string? KntKartaLoj { get; set; }

    /// <summary>
    /// Czy jest uczestnikiem programu lojalnościowego
    /// </summary>
    public string? KntProgramLoj { get; set; }

    public string? KntOdbiorca { get; set; }

    public string? Hierarchy2Level1Name { get; set; }

    public string? Hierarchy2Level1OrgId { get; set; }

    public int? Hierarchy2Level1Id { get; set; }

    public string? Hierarchy2Level2Name { get; set; }

    public string? Hierarchy2Level2OrgId { get; set; }

    public int? Hierarchy2Level2Id { get; set; }

    public string? Hierarchy2Level3Name { get; set; }

    public string? Hierarchy2Level3OrgId { get; set; }

    public int? Hierarchy2Level3Id { get; set; }

    public string? Hierarchy2Level4Name { get; set; }

    public string? Hierarchy2Level4OrgId { get; set; }

    public int? Hierarchy2Level4Id { get; set; }

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentowMgmDsts { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentowMgmKnts { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual ICollection<FktAnalizaRfm> FktAnalizaRfms { get; set; } = new List<FktAnalizaRfm>();

    public virtual ICollection<FktAnkiety> FktAnkieties { get; set; } = new List<FktAnkiety>();

    public virtual ICollection<FktCennik> FktCenniks { get; set; } = new List<FktCennik>();

    public virtual ICollection<FktDekrety> FktDekretyDtKnds { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDekrety> FktDekretyDtKnts { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDekrety> FktDekretyDtPlats { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupuKdzKnds { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupuKdzKnts { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupuKdzPlats { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjas { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjeKamAkws { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjeKamKnts { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKoszty> FktKosztyKosztAkws { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztDsts { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztKnds { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztKnts { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztPlats { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktLimityKontrahentow> FktLimityKontrahentows { get; set; } = new List<FktLimityKontrahentow>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmDsts { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmKnts { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrDsts { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrKnDs { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrKnts { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanies { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPmrszKntDocGs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPmrszKntGs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktOferty> FktOfertyOfeAkws { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktOferty> FktOfertyOfeKnds { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktOferty> FktOfertyOfeKnts { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktOferty> FktOfertyOfePlats { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezacePlbAkws { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezacePlbKnds { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezacePlbKnts { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezacePlbPlats { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDzienPndAkws { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDzienPndKnds { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDzienPndKnts { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDzienPndPlats { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapAkws { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapKnds { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapKntPlaskis { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapKnts { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapPlats { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkiRzrAkws { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkiRzrKnds { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkiRzrKnts { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkiRzrPlats { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsAkws { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsDsts { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsKnds { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsKnts { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsPlats { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSrednie> FktPlatnosciSredniePlsAkws { get; set; } = new List<FktPlatnosciSrednie>();

    public virtual ICollection<FktPlatnosciSrednie> FktPlatnosciSredniePlsKnds { get; set; } = new List<FktPlatnosciSrednie>();

    public virtual ICollection<FktPlatnosciSrednie> FktPlatnosciSredniePlsKnts { get; set; } = new List<FktPlatnosciSrednie>();

    public virtual ICollection<FktPlatnosciSrednie> FktPlatnosciSredniePlsPlats { get; set; } = new List<FktPlatnosciSrednie>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKaStkKnds { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKaStkKnts { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszrutumPmaKnDs { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszrutumPmaKnts { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowaPsmKnDs { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowaPsmKnts { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKosztyPzkKnds { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKosztyPzkKnts { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZleceniumPrzKnDs { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZleceniumPrzKnts { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZpPzpKntDocGs { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZpPzpKntGs { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktProgramLojalnosciowy> FktProgramLojalnosciowies { get; set; } = new List<FktProgramLojalnosciowy>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanePrmltDocKntGs { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanePrmltKntGs { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanePrmltPlatGs { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkAkws { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkDsts { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkKnds { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkKnts { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkPlats { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatAkws { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatDsts { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatKnds { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatKnts { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatPlats { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabatyRetro> FktRabatyRetros { get; set; } = new List<FktRabatyRetro>();

    public virtual ICollection<FktRaportyWizyt> FktRaportyWizyts { get; set; } = new List<FktRaportyWizyt>();

    public virtual ICollection<FktReklamacje> FktReklamacjeReklAkws { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktReklamacje> FktReklamacjeReklKnds { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktReklamacje> FktReklamacjeReklKnts { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktRezerwacje> FktRezerwacjes { get; set; } = new List<FktRezerwacje>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprAkws { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprDsts { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprKnds { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprKnts { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprPlats { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSrodkiTrwale> FktSrodkiTrwales { get; set; } = new List<FktSrodkiTrwale>();

    public virtual ICollection<FktTransport> FktTransportTrsKns { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktTransport> FktTransportTrsKntDokZwiazanies { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktUmowyDokPowiazane> FktUmowyDokPowiazaneDopKnds { get; set; } = new List<FktUmowyDokPowiazane>();

    public virtual ICollection<FktUmowyDokPowiazane> FktUmowyDokPowiazaneDopKnts { get; set; } = new List<FktUmowyDokPowiazane>();

    public virtual ICollection<FktUmowy> FktUmowyUmyKnds { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktUmowy> FktUmowyUmyKnts { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktWizyty> FktWizyties { get; set; } = new List<FktWizyty>();

    public virtual ICollection<FktWizytyElement> FktWizytyElements { get; set; } = new List<FktWizytyElement>();

    public virtual ICollection<FktWm> FktWms { get; set; } = new List<FktWm>();

    public virtual ICollection<FktWydatki> FktWydatkis { get; set; } = new List<FktWydatki>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnosciZptDsts { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnosciZptKnds { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnosciZptKnts { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnosciZptPlatniks { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZakupy> FktZakupyZkpAkws { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpDsts { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpKnds { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpKnts { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpPlats { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlientumZakAkws { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlientumZakKnDs { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlientumZakKnts { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlientumZakPlats { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhAkws { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhKnDs { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhKnts { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhPlats { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmAkws { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmKnDs { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmKnts { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmPlats { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazAkws { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazKnDs { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazKnts { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazPlats { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZapytaniaOfertowe> FktZapytaniaOfertoweZosAkws { get; set; } = new List<FktZapytaniaOfertowe>();

    public virtual ICollection<FktZapytaniaOfertowe> FktZapytaniaOfertoweZosKnDs { get; set; } = new List<FktZapytaniaOfertowe>();

    public virtual ICollection<FktZapytaniaOfertowe> FktZapytaniaOfertoweZosKnts { get; set; } = new List<FktZapytaniaOfertowe>();

    public virtual ICollection<FktZestawienium> FktZestawieniumZksKnds { get; set; } = new List<FktZestawienium>();

    public virtual ICollection<FktZestawienium> FktZestawieniumZksKnts { get; set; } = new List<FktZestawienium>();

    public virtual ICollection<FktZestawienium> FktZestawieniumZksPlats { get; set; } = new List<FktZestawienium>();

    public virtual WymGeografium? KntGeo { get; set; }

    public virtual WymMiejscowosc? KntMiejscowoscNavigation { get; set; }

    public virtual WymObszar? KntObszar { get; set; }

    public virtual WymPracownik? KntPracownik { get; set; }

    public virtual WymSposobDostawy? KntSposobDostawy { get; set; }

    public virtual WymZrodloDanych KntZrodg { get; set; } = null!;

    public virtual ICollection<WymKonto> WymKontos { get; set; } = new List<WymKonto>();

    public virtual ICollection<WymProdukt> WymProdukts { get; set; } = new List<WymProdukt>();

    public virtual ICollection<WymProjekt> WymProjekts { get; set; } = new List<WymProjekt>();
}
