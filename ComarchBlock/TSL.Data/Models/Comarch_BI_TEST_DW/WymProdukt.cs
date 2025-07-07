using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymProdukt
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ProdDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ProdDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ProdDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int ProdId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ProdKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ProdKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ProdOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ProdOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ProdParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ProdParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ProdRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] ProdRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ProdSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ProdTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ProdTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ProdZrodgid { get; set; }

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
    /// Identyfikator kategorii rynkowej. Relacja do wymiaru WYM_KategorieRynkowe
    /// </summary>
    public int? ProdKategoriaRynkowaId { get; set; }

    /// <summary>
    /// Identyfikator pracownika. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int? ProdPracownikId { get; set; }

    /// <summary>
    /// Identyfikator producenta. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int? ProdProducentId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? ProdStrukturaFirmyId { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? FaktyProd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ProdAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ProdAktualneOrgParId { get; set; }

    /// <summary>
    /// Informacja o tym, czy produkt ma flagę &apos;Archiwalny&apos;. Nie - archiwalny, Tak - aktywny
    /// </summary>
    public string? ProdAktywny { get; set; }

    /// <summary>
    /// Nazwa atrybutu1 pobranego z karty produktu
    /// </summary>
    public string? ProdAtrybut1Nazwa { get; set; }

    /// <summary>
    /// Wartość atrybutu1 pobranego z karty produktu
    /// </summary>
    public string? ProdAtrybut1Wartosc { get; set; }

    /// <summary>
    /// Nazwa atrybutu2 pobranego z karty produktu
    /// </summary>
    public string? ProdAtrybut2Nazwa { get; set; }

    /// <summary>
    /// Wartość atrybutu2 pobranego z karty produktu
    /// </summary>
    public string? ProdAtrybut2Wartosc { get; set; }

    /// <summary>
    /// Nazwa atrybutu3 pobranego z karty produktu
    /// </summary>
    public string? ProdAtrybut3Nazwa { get; set; }

    /// <summary>
    /// Nazwa atrybutu3 pobranego z karty produktu
    /// </summary>
    public string? ProdAtrybut3Wartosc { get; set; }

    /// <summary>
    /// Domyślny czas dostawy produktu
    /// </summary>
    public int? ProdCzasDostawy { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? ProdDataPierwszejTranSpr { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? ProdDataPierwszejTranZkp { get; set; }

    /// <summary>
    /// Jednostka podstawowa dla produktu
    /// </summary>
    public string? ProdJmpodstawowa { get; set; }

    /// <summary>
    /// Kod produktu
    /// </summary>
    public string? ProdKod { get; set; }

    /// <summary>
    /// Domyślna marża minimalna dla produktu
    /// </summary>
    public decimal? ProdMarzaMinimalna { get; set; }

    /// <summary>
    /// Nazwa produktu
    /// </summary>
    public string? ProdNazwa { get; set; }

    /// <summary>
    /// Typ obiektu
    /// </summary>
    public int? ProdObiTyp { get; set; }

    /// <summary>
    /// Objętość towaru
    /// </summary>
    public decimal? ProdObjetosc { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? ProdOpis { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public string? ProdOrgAtrId { get; set; }

    /// <summary>
    /// kolumna niewykorzystywana
    /// </summary>
    public int? ProdPoprzednikId { get; set; }

    /// <summary>
    /// Rodzaj produktu
    /// </summary>
    public string? ProdRodzaj { get; set; }

    /// <summary>
    /// Symbol produktu
    /// </summary>
    public string? ProdSymbol { get; set; }

    /// <summary>
    /// Adres www produktu
    /// </summary>
    public string? ProdUrl { get; set; }

    /// <summary>
    /// Waga produktu
    /// </summary>
    public decimal? ProdWaga { get; set; }

    /// <summary>
    /// Wartość punktowa produktu
    /// </summary>
    public decimal? ProdWartoscPunktowa { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? ProdWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? ProdWymTyp { get; set; }

    /// <summary>
    /// Kod EAN produktu
    /// </summary>
    public string? ProdEan { get; set; }

    /// <summary>
    /// PKWIU produktu
    /// </summary>
    public string? ProdPkwiu { get; set; }

    /// <summary>
    /// Marka produktu
    /// </summary>
    public string? ProdMarka { get; set; }

    /// <summary>
    /// Flaga przypisana towarowi w analizie ABC/XYZ
    /// </summary>
    public byte? ProdAnalizaAbcxyz { get; set; }

    public int ProdObrazId { get; set; }

    /// <summary>
    /// Informacja, czy produkt jest kaucją
    /// </summary>
    public string? ProdKaucja { get; set; }

    /// <summary>
    /// Nazwa dodatkowa
    /// </summary>
    public string? ProdNazwaDodatkowa { get; set; }

    /// <summary>
    /// Kod PCN
    /// </summary>
    public string? ProdKodPcn { get; set; }

    /// <summary>
    /// Czy produkt uczestniczył kiedykolwiek w programie lojalnościowym
    /// </summary>
    public string? ProdProgramLojalnosciowy { get; set; }

    /// <summary>
    /// Czy produkt był nagrodą w programie lojalnościowym
    /// </summary>
    public string? ProdProgramLojalnosciowyNagroda { get; set; }

    public string? ProdMpp { get; set; }

    public string? ProdGtu { get; set; }

    public string? ProdTyp { get; set; }

    public string? ProdRodzajBonow { get; set; }

    public int ProdDostepnoscId { get; set; }

    public string? ProdKrajPoch { get; set; }

    public string? ProdCertyfikat { get; set; }

    public decimal? ProdOplataCukrowaStala { get; set; }

    public decimal? ProdOplataCukrowaZmienna { get; set; }

    public decimal? ProdOplataCukrowaKofeina { get; set; }

    public string? Hierarchy3Level1Name { get; set; }

    public string? Hierarchy3Level1OrgId { get; set; }

    public int? Hierarchy3Level1Id { get; set; }

    public string? Hierarchy3Level2Name { get; set; }

    public string? Hierarchy3Level2OrgId { get; set; }

    public int? Hierarchy3Level2Id { get; set; }

    public string? Hierarchy3Level3Name { get; set; }

    public string? Hierarchy3Level3OrgId { get; set; }

    public int? Hierarchy3Level3Id { get; set; }

    public string? Hierarchy3Level4Name { get; set; }

    public string? Hierarchy3Level4OrgId { get; set; }

    public int? Hierarchy3Level4Id { get; set; }

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentows { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual ICollection<FktAnkiety> FktAnkieties { get; set; } = new List<FktAnkiety>();

    public virtual ICollection<FktCennik> FktCenniks { get; set; } = new List<FktCennik>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktJednostkiPomocnicze> FktJednostkiPomocniczes { get; set; } = new List<FktJednostkiPomocnicze>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdProdGs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdSklGs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktMagazynyNormatywy> FktMagazynyNormatywies { get; set; } = new List<FktMagazynyNormatywy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchies { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMags { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynySrednieRuchyDokMag> FktMagazynySrednieRuchyDokMags { get; set; } = new List<FktMagazynySrednieRuchyDokMag>();

    public virtual ICollection<FktMagazynySrednie> FktMagazynySrednies { get; set; } = new List<FktMagazynySrednie>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanies { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktMarszrutum> FktMarszruta { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktOferty> FktOferties { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkis { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSrednie> FktPlatnosciSrednies { get; set; } = new List<FktPlatnosciSrednie>();

    public virtual ICollection<FktProdukcjaDokumenty> FktProdukcjaDokumenties { get; set; } = new List<FktProdukcjaDokumenty>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjes { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszruta { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowaPsmCels { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowaPsmProds { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZlecenia { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKoszties { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZpPzpMatGs { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZpPzpProdGs { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanes { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabatyRetro> FktRabatyRetros { get; set; } = new List<FktRabatyRetro>();

    public virtual ICollection<FktRaportyWizyt> FktRaportyWizyts { get; set; } = new List<FktRaportyWizyt>();

    public virtual ICollection<FktReklamacje> FktReklamacjes { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktRezerwacje> FktRezerwacjes { get; set; } = new List<FktRezerwacje>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktUmowy> FktUmowies { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktUmowyDokPowiazane> FktUmowyDokPowiazanes { get; set; } = new List<FktUmowyDokPowiazane>();

    public virtual ICollection<FktWm> FktWms { get; set; } = new List<FktWm>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZamienniki> FktZamiennikiZamProds { get; set; } = new List<FktZamienniki>();

    public virtual ICollection<FktZamienniki> FktZamiennikiZamZamienniks { get; set; } = new List<FktZamienniki>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandls { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmags { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZapytaniaOfertowe> FktZapytaniaOfertowes { get; set; } = new List<FktZapytaniaOfertowe>();

    public virtual WymCzasDzien ProdDostepnosc { get; set; } = null!;

    public virtual WymKategorieRynkowe? ProdKategoriaRynkowa { get; set; }

    public virtual WymObraz ProdObraz { get; set; } = null!;

    public virtual WymPracownik? ProdPracownik { get; set; }

    public virtual WymKontrahent? ProdProducent { get; set; }

    public virtual WymStrukturaFirmy? ProdStrukturaFirmy { get; set; }

    public virtual WymZrodloDanych ProdZrodg { get; set; } = null!;

    public virtual ICollection<WymReceptury> WymRecepturies { get; set; } = new List<WymReceptury>();
}
