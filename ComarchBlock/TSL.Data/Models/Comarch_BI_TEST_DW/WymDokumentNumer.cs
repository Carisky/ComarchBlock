using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymDokumentNumer
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokNumerDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokNumerDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string DokNumerDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int DokNumerId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokNumerKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokNumerKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string DokNumerOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokNumerOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokNumerParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokNumerParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int DokNumerRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] DokNumerRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokNumerSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DokNumerTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DokNumerTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int DokNumerZrodgid { get; set; }

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
    /// Identyfikator cechy transakcji. Relacja do wymiaru WYM_CechaTransakcji
    /// </summary>
    public int? DokNumerCechaTransakcjiId { get; set; }

    /// <summary>
    /// Identyfikator serii dokumentu. Relacja do wymiaru WYM_DokumentSeria
    /// </summary>
    public int? DokNumerDokSeriaId { get; set; }

    /// <summary>
    /// Identyfikator statusu dokumentu. Relacja do wymiaru WYM_DokumentStatus
    /// </summary>
    public int? DokNumerDokStatusId { get; set; }

    /// <summary>
    /// Identyfikator typu dokumentu. Relacja do wymiaru WYM_DokumentTyp
    /// </summary>
    public int? DokNumerDokTypId { get; set; }

    /// <summary>
    /// Identyfikator kodu fiaska. Relacja do wymiaru WYM_KodFiaska
    /// </summary>
    public int? DokNumerKodFiaskaId { get; set; }

    /// <summary>
    /// Identyfikator operatora dokumentu. Relacja do wymiaru WYM_Operator
    /// </summary>
    public int? DokNumerOperatorId { get; set; }

    /// <summary>
    /// Identyfikator sposobu dostawy. Relacja do wymiaru WYM_SposobDostawy
    /// </summary>
    public int? DokNumerSposobDostawyId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokNumerAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokNumerAktualneOrgParId { get; set; }

    /// <summary>
    /// Informacja, czy dokument jest aktywny
    /// </summary>
    public int? DokNumerAktywny { get; set; }

    /// <summary>
    /// Data dokumentu w formacie Clarion
    /// </summary>
    public int? DokNumerDataDokumentu { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public string? DokNumerGrupowanie { get; set; }

    /// <summary>
    /// Informacja, czy został ustalony koszt na dokumencie
    /// </summary>
    public string? DokNumerKosztUstalono { get; set; }

    /// <summary>
    /// Nazwa dokumentu
    /// </summary>
    public string? DokNumerNazwa { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? DokNumerOpis { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? DokNumerOrgAtrId { get; set; }

    /// <summary>
    /// Opis dokumentu
    /// </summary>
    public string? DokNumerOwnOpis { get; set; }

    /// <summary>
    /// Pełny numer dokumentu
    /// </summary>
    public string? DokNumerPelnyNumer { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? DokNumerPoprzednikId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokNumerSpiOrgId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? DokNumerWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? DokNumerWymTyp { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? FaktyDok { get; set; }

    /// <summary>
    /// Do ofert - 0 - przedawniona, 1 - aktualna
    /// </summary>
    public int? DokNumerCzyAktualny { get; set; }

    /// <summary>
    /// Stan - dotyczy zamówień oraz ofert
    /// </summary>
    public string? DokNumerStan { get; set; }

    /// <summary>
    /// Dokument obcy do dokumentu
    /// </summary>
    public string? DokNumerDokumentObcy { get; set; }

    public string? DokNumerOpisNaglowka { get; set; }

    /// <summary>
    /// Identyfikator statusu rozliczenia dokumentu. Relation to dimension DokumentStatus
    /// </summary>
    public int? DokNumerDokStatusRozliczeniaId { get; set; }

    public string? DokNumerMpp { get; set; }

    public string? DokNumerRejestrVat { get; set; }

    public string? DokNumerProceduryJpk { get; set; }

    public string? DokNumerPrzyczynaZw { get; set; }

    public string? DokNumerZwolnioneDoProd { get; set; }

    public string? DokNumerNumerListu { get; set; }

    public string? DokNumerStanPrzesylki { get; set; }

    public string? DokNumerKurier { get; set; }

    public string? DokNumerNumerSformatowany { get; set; }

    public string? DokNumerPozycje { get; set; }

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentowMgmDokumentHands { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentowMgmDokumentMags { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual WymCechaTransakcji? DokNumerCechaTransakcji { get; set; }

    public virtual WymDokumentSerium? DokNumerDokSeria { get; set; }

    public virtual WymDokumentStatus? DokNumerDokStatus { get; set; }

    public virtual WymDokumentStatus? DokNumerDokStatusRozliczenia { get; set; }

    public virtual WymDokumentTyp? DokNumerDokTyp { get; set; }

    public virtual WymKodFiaska? DokNumerKodFiaska { get; set; }

    public virtual WymOperator? DokNumerOperator { get; set; }

    public virtual WymSposobDostawy? DokNumerSposobDostawy { get; set; }

    public virtual WymZrodloDanych DokNumerZrodg { get; set; } = null!;

    public virtual ICollection<FktDekrety> FktDekretyDtDokNumers { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDekrety> FktDekretyDtSpiNumers { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupuKdzDokKnumers { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupuKdzDokNumers { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupuKdzDokZrnumers { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktDokumenty> FktDokumentyDokDokNumerHands { get; set; } = new List<FktDokumenty>();

    public virtual ICollection<FktDokumenty> FktDokumentyDokDokNumerMags { get; set; } = new List<FktDokumenty>();

    public virtual ICollection<FktDokumenty> FktDokumentyDokDokNumerOves { get; set; } = new List<FktDokumenty>();

    public virtual ICollection<FktDokumenty> FktDokumentyDokDokNumerZams { get; set; } = new List<FktDokumenty>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdDokNumerGidpwNavigations { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdDokNumerGidrwNavigations { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdDokNumerGs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdDokNumerZkNavigations { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjes { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKoszty> FktKosztyKosztDokNumers { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztDokWysylkis { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztPlatDokNumers { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztSpiNumers { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmDokumentHands { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmDokumentMags { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrDokNumerMags { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrDokNumers { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanies { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganieMgzDokNumers { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganieMgzSpiNumers { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktMarszrutum> FktMarszruta { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktNarzedziowniaZuzyciaRuchy> FktNarzedziowniaZuzyciaRuchies { get; set; } = new List<FktNarzedziowniaZuzyciaRuchy>();

    public virtual ICollection<FktNarzedziownium> FktNarzedziowniumNrzDokRwlikwidacjiNavigations { get; set; } = new List<FktNarzedziownium>();

    public virtual ICollection<FktNarzedziownium> FktNarzedziowniumNrzDokRwwydaniaNavigations { get; set; } = new List<FktNarzedziownium>();

    public virtual ICollection<FktNarzedziownium> FktNarzedziowniumNrzDokRwzdaniaNavigations { get; set; } = new List<FktNarzedziownium>();

    public virtual ICollection<FktOferty> FktOfertyOfeDokNumerZrds { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktOferty> FktOfertyOfeDokNumers { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezacePlbDokNumers { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezacePlbSpiNumers { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDzienPndDokNumers { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDzienPndSpiNumers { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapDokNumerLokata { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapDokNumers { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapKazNumers { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapPlatNumers { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapRejestries { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapSpiNumers { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkiRzrDokNumers { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkiRzrRejestries { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkiRzrSpiNumers { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsDokNumers { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsSpiNumers { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSrednie> FktPlatnosciSredniePlsDokNumers { get; set; } = new List<FktPlatnosciSrednie>();

    public virtual ICollection<FktPlatnosciSrednie> FktPlatnosciSredniePlsSpiNumers { get; set; } = new List<FktPlatnosciSrednie>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKas { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktProdukcjaDokumenty> FktProdukcjaDokumentyProdDokDokNumers { get; set; } = new List<FktProdukcjaDokumenty>();

    public virtual ICollection<FktProdukcjaDokumenty> FktProdukcjaDokumentyProdDokDokRealizacjas { get; set; } = new List<FktProdukcjaDokumenty>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjePkkDokNumerPwNavigations { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjePkkDokNumerRwNavigations { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjePkkDokNumerZpNavigations { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszrutumPmaDokNumers { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszrutumPmaDokRealizacjas { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszrutumPmaZamDokNumers { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowaPsmDokNumers { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowaPsmRwdokNumers { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowaPsmZamDokNumers { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKosztyPzkDokNumers { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKosztyPzkZamDokNumers { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZleceniumPrzDokNumers { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZleceniumPrzZamDoknumers { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZpPzpDokNumerNadZlecNavigations { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZpPzpDokNumerPwNavigations { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZpPzpDokNumerRwNavigations { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZpPzpDokNumerZpNavigations { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanes { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkDokNumers { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkSpiNumers { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatDokNumers { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatSpiDokNumers { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktReklamacje> FktReklamacjeReklDokNumers { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktReklamacje> FktReklamacjeReklZrdDokNumers { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktRezerwacje> FktRezerwacjes { get; set; } = new List<FktRezerwacje>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprDokNumers { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprPlatDokNumers { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprSpiNumers { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSrodkiTrwale> FktSrodkiTrwales { get; set; } = new List<FktSrodkiTrwale>();

    public virtual ICollection<FktTransport> FktTransportTrsDokNumerWys { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktTransport> FktTransportTrsDokNumers { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktTransport> FktTransportTrsDokZwiazanies { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktUmowyDokPowiazane> FktUmowyDokPowiazanes { get; set; } = new List<FktUmowyDokPowiazane>();

    public virtual ICollection<FktUmowyDokumenty> FktUmowyDokumenties { get; set; } = new List<FktUmowyDokumenty>();

    public virtual ICollection<FktWm> FktWms { get; set; } = new List<FktWm>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnosciZptDokNumers { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnosciZptSpiNumers { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZakupy> FktZakupyZkpDokNumers { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpSadDokGs { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpSpiNumers { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpZamNumers { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhDokNumerZams { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhDokNumers { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmDokNumerZams { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmDokNumers { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<SFktKosztySprzedazy> SFktKosztySprzedazyKsprDokNumerGs { get; set; } = new List<SFktKosztySprzedazy>();

    public virtual ICollection<SFktKosztySprzedazy> SFktKosztySprzedazyKsprDokWysylkiGs { get; set; } = new List<SFktKosztySprzedazy>();

    public virtual ICollection<SFktRabatySprzedazy> SFktRabatySprzedazies { get; set; } = new List<SFktRabatySprzedazy>();

    public virtual ICollection<WymDostawa> WymDostawas { get; set; } = new List<WymDostawa>();
}
