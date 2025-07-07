using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymZrodloDanych
{
    /// <summary>
    /// Klucz główny
    /// </summary>
    public int ZrodGid { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int ZrodId { get; set; }

    /// <summary>
    /// Nazwa źródła
    /// </summary>
    public string ZrodNazwa { get; set; } = null!;

    /// <summary>
    /// Opis źródła
    /// </summary>
    public string ZrodOpis { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZrodOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] ZrodRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZrodTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZrodTsupdate { get; set; }

    public virtual ICollection<AddClassAssign> AddClassAssigns { get; set; } = new List<AddClassAssign>();

    public virtual ICollection<AddClassLevel> AddClassLevels { get; set; } = new List<AddClassLevel>();

    public virtual ICollection<AddClassNode> AddClassNodes { get; set; } = new List<AddClassNode>();

    public virtual ICollection<AddParameter> AddParameters { get; set; } = new List<AddParameter>();

    public virtual ICollection<AttachedDynamicObjectsInfo> AttachedDynamicObjectsInfos { get; set; } = new List<AttachedDynamicObjectsInfo>();

    public virtual ICollection<AttributesAsMeasuresInfo> AttributesAsMeasuresInfos { get; set; } = new List<AttributesAsMeasuresInfo>();

    public virtual ICollection<AttributesInfo> AttributesInfos { get; set; } = new List<AttributesInfo>();

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentows { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual ICollection<BdtWymDelegacja> BdtWymDelegacjas { get; set; } = new List<BdtWymDelegacja>();

    public virtual ICollection<BdtWymLimitTyp> BdtWymLimitTyps { get; set; } = new List<BdtWymLimitTyp>();

    public virtual ICollection<BdtWymLimityKontrahentum> BdtWymLimityKontrahenta { get; set; } = new List<BdtWymLimityKontrahentum>();

    public virtual ICollection<BdtWymMaterial> BdtWymMaterials { get; set; } = new List<BdtWymMaterial>();

    public virtual ICollection<BdtWymRodzajUboczny> BdtWymRodzajUbocznies { get; set; } = new List<BdtWymRodzajUboczny>();

    public virtual ICollection<BdtWymZestawieniaStruktura> BdtWymZestawieniaStrukturas { get; set; } = new List<BdtWymZestawieniaStruktura>();

    public virtual ICollection<DimensionsInfo> DimensionsInfos { get; set; } = new List<DimensionsInfo>();

    public virtual ICollection<DynamicObjectsTranslation> DynamicObjectsTranslations { get; set; } = new List<DynamicObjectsTranslation>();

    public virtual ICollection<FctAttributeMeasure> FctAttributeMeasures { get; set; } = new List<FctAttributeMeasure>();

    public virtual ICollection<FeaturesInfo> FeaturesInfos { get; set; } = new List<FeaturesInfo>();

    public virtual ICollection<FktAnalizaRfm> FktAnalizaRfms { get; set; } = new List<FktAnalizaRfm>();

    public virtual ICollection<FktAnkiety> FktAnkieties { get; set; } = new List<FktAnkiety>();

    public virtual ICollection<FktCennik> FktCenniks { get; set; } = new List<FktCennik>();

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktDokumenty> FktDokumenties { get; set; } = new List<FktDokumenty>();

    public virtual ICollection<FktFlotum> FktFlota { get; set; } = new List<FktFlotum>();

    public virtual ICollection<FktJednostkiPomocnicze> FktJednostkiPomocniczes { get; set; } = new List<FktJednostkiPomocnicze>();

    public virtual ICollection<FktJgospodarczeGu> FktJgospodarczeGus { get; set; } = new List<FktJgospodarczeGu>();

    public virtual ICollection<FktKampanieEtapy> FktKampanieEtapies { get; set; } = new List<FktKampanieEtapy>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjas { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjes { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKursyWalut> FktKursyWaluts { get; set; } = new List<FktKursyWalut>();

    public virtual ICollection<FktLimityKontrahentow> FktLimityKontrahentows { get; set; } = new List<FktLimityKontrahentow>();

    public virtual ICollection<FktLudnoscGu> FktLudnoscGus { get; set; } = new List<FktLudnoscGu>();

    public virtual ICollection<FktMagazynyNormatywy> FktMagazynyNormatywies { get; set; } = new List<FktMagazynyNormatywy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchies { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMags { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynySrednieRuchyDokMag> FktMagazynySrednieRuchyDokMags { get; set; } = new List<FktMagazynySrednieRuchyDokMag>();

    public virtual ICollection<FktMagazynySrednie> FktMagazynySrednies { get; set; } = new List<FktMagazynySrednie>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanies { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktMarszrutum> FktMarszruta { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktNarzedziownium> FktNarzedziownia { get; set; } = new List<FktNarzedziownium>();

    public virtual ICollection<FktNarzedziowniaZuzyciaRuchy> FktNarzedziowniaZuzyciaRuchies { get; set; } = new List<FktNarzedziowniaZuzyciaRuchy>();

    public virtual ICollection<FktNarzedziowniaZuzyciaStany> FktNarzedziowniaZuzyciaStanies { get; set; } = new List<FktNarzedziowniaZuzyciaStany>();

    public virtual ICollection<FktOferty> FktOferties { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktParametryEtl> FktParametryEtls { get; set; } = new List<FktParametryEtl>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkis { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSrednie> FktPlatnosciSrednies { get; set; } = new List<FktPlatnosciSrednie>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKas { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktPomFunkcjeKontaMap> FktPomFunkcjeKontaMaps { get; set; } = new List<FktPomFunkcjeKontaMap>();

    public virtual ICollection<FktPomZestawieniaFunkcjeMap> FktPomZestawieniaFunkcjeMaps { get; set; } = new List<FktPomZestawieniaFunkcjeMap>();

    public virtual ICollection<FktPracownikCzasPracy> FktPracownikCzasPracies { get; set; } = new List<FktPracownikCzasPracy>();

    public virtual ICollection<FktPracownikEtaty> FktPracownikEtaties { get; set; } = new List<FktPracownikEtaty>();

    public virtual ICollection<FktPracownikLimityNieobecnosci> FktPracownikLimityNieobecnoscis { get; set; } = new List<FktPracownikLimityNieobecnosci>();

    public virtual ICollection<FktPracownikNieobecnosci> FktPracownikNieobecnoscis { get; set; } = new List<FktPracownikNieobecnosci>();

    public virtual ICollection<FktPracownikObecnosci> FktPracownikObecnoscis { get; set; } = new List<FktPracownikObecnosci>();

    public virtual ICollection<FktPracownikUmowyKwoty> FktPracownikUmowyKwoties { get; set; } = new List<FktPracownikUmowyKwoty>();

    public virtual ICollection<FktPracownikWyplaty> FktPracownikWyplaties { get; set; } = new List<FktPracownikWyplaty>();

    public virtual ICollection<FktProdukcjaDokumenty> FktProdukcjaDokumenties { get; set; } = new List<FktProdukcjaDokumenty>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjes { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszruta { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowas { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZlecenia { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKoszties { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZps { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktProgramLojalnosciowy> FktProgramLojalnosciowies { get; set; } = new List<FktProgramLojalnosciowy>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanes { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPrzestoje> FktPrzestojes { get; set; } = new List<FktPrzestoje>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabatyRetroAgregacje> FktRabatyRetroAgregacjes { get; set; } = new List<FktRabatyRetroAgregacje>();

    public virtual ICollection<FktRabatyRetro> FktRabatyRetros { get; set; } = new List<FktRabatyRetro>();

    public virtual ICollection<FktRaportyWizyt> FktRaportyWizyts { get; set; } = new List<FktRaportyWizyt>();

    public virtual ICollection<FktReklamacjeRealizacje> FktReklamacjeRealizacjes { get; set; } = new List<FktReklamacjeRealizacje>();

    public virtual ICollection<FktReklamacje> FktReklamacjes { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktRezerwacje> FktRezerwacjes { get; set; } = new List<FktRezerwacje>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSrodkiTrwale> FktSrodkiTrwales { get; set; } = new List<FktSrodkiTrwale>();

    public virtual ICollection<FktTransport> FktTransports { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktUmowy> FktUmowies { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktUmowyDokPowiazane> FktUmowyDokPowiazanes { get; set; } = new List<FktUmowyDokPowiazane>();

    public virtual ICollection<FktUmowyDokumenty> FktUmowyDokumenties { get; set; } = new List<FktUmowyDokumenty>();

    public virtual ICollection<FktWizyty> FktWizyties { get; set; } = new List<FktWizyty>();

    public virtual ICollection<FktWizytyElement> FktWizytyElements { get; set; } = new List<FktWizytyElement>();

    public virtual ICollection<FktWm> FktWms { get; set; } = new List<FktWm>();

    public virtual ICollection<FktWydatki> FktWydatkis { get; set; } = new List<FktWydatki>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZamienniki> FktZamiennikis { get; set; } = new List<FktZamienniki>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandls { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmags { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZapytaniaOfertowe> FktZapytaniaOfertowes { get; set; } = new List<FktZapytaniaOfertowe>();

    public virtual ICollection<FktZestawienium> FktZestawienia { get; set; } = new List<FktZestawienium>();

    public virtual ICollection<FktZestawieniaKsiegoweErp> FktZestawieniaKsiegoweErps { get; set; } = new List<FktZestawieniaKsiegoweErp>();

    public virtual ICollection<HierarchiesInfo> HierarchiesInfos { get; set; } = new List<HierarchiesInfo>();

    public virtual ICollection<HierarchiesLevelInfo> HierarchiesLevelInfos { get; set; } = new List<HierarchiesLevelInfo>();

    public virtual ICollection<SFktAtrybuty> SFktAtrybuties { get; set; } = new List<SFktAtrybuty>();

    public virtual ICollection<SFktKosztySprzedazy> SFktKosztySprzedazies { get; set; } = new List<SFktKosztySprzedazy>();

    public virtual ICollection<SFktOpisyAnalityczne> SFktOpisyAnalitycznes { get; set; } = new List<SFktOpisyAnalityczne>();

    public virtual ICollection<SFktRabatySprzedazy> SFktRabatySprzedazies { get; set; } = new List<SFktRabatySprzedazy>();

    public virtual ICollection<SPomAtrybuty> SPomAtrybuties { get; set; } = new List<SPomAtrybuty>();

    public virtual ICollection<SPomOpisyAnalityczne> SPomOpisyAnalitycznes { get; set; } = new List<SPomOpisyAnalityczne>();

    public virtual ICollection<SPomPropagacjaAtrybutow> SPomPropagacjaAtrybutows { get; set; } = new List<SPomPropagacjaAtrybutow>();

    public virtual ICollection<SPomWymiaryKlasy> SPomWymiaryKlasies { get; set; } = new List<SPomWymiaryKlasy>();

    public virtual ICollection<SPomWymiaryKlasyModyfikacje> SPomWymiaryKlasyModyfikacjes { get; set; } = new List<SPomWymiaryKlasyModyfikacje>();

    public virtual ICollection<WymAdre> WymAdres { get; set; } = new List<WymAdre>();

    public virtual ICollection<WymAlokacja> WymAlokacjas { get; set; } = new List<WymAlokacja>();

    public virtual ICollection<WymAnkietum> WymAnkieta { get; set; } = new List<WymAnkietum>();

    public virtual ICollection<WymAtrybuty> WymAtrybuties { get; set; } = new List<WymAtrybuty>();

    public virtual ICollection<WymBudzet> WymBudzets { get; set; } = new List<WymBudzet>();

    public virtual ICollection<WymCechaTransakcji> WymCechaTransakcjis { get; set; } = new List<WymCechaTransakcji>();

    public virtual ICollection<WymCechy> WymCechies { get; set; } = new List<WymCechy>();

    public virtual ICollection<WymCechyKlasy> WymCechyKlasies { get; set; } = new List<WymCechyKlasy>();

    public virtual ICollection<WymCennik> WymCenniks { get; set; } = new List<WymCennik>();

    public virtual ICollection<WymCenyRynkowe> WymCenyRynkowes { get; set; } = new List<WymCenyRynkowe>();

    public virtual ICollection<WymCrmetapy> WymCrmetapies { get; set; } = new List<WymCrmetapy>();

    public virtual ICollection<WymCrmkampanium> WymCrmkampania { get; set; } = new List<WymCrmkampanium>();

    public virtual ICollection<WymCzasGodzina> WymCzasGodzinas { get; set; } = new List<WymCzasGodzina>();

    public virtual ICollection<WymCzasMiesiac> WymCzasMiesiacs { get; set; } = new List<WymCzasMiesiac>();

    public virtual ICollection<WymCzasMinutum> WymCzasMinuta { get; set; } = new List<WymCzasMinutum>();

    public virtual ICollection<WymCzasRok> WymCzasRoks { get; set; } = new List<WymCzasRok>();

    public virtual ICollection<WymCzasTrwaniaTel> WymCzasTrwaniaTels { get; set; } = new List<WymCzasTrwaniaTel>();

    public virtual ICollection<WymCzasTrwaniaTypTel> WymCzasTrwaniaTypTels { get; set; } = new List<WymCzasTrwaniaTypTel>();

    public virtual ICollection<WymCzasTydzien> WymCzasTydziens { get; set; } = new List<WymCzasTydzien>();

    public virtual ICollection<WymCzynnosc> WymCzynnoscs { get; set; } = new List<WymCzynnosc>();

    public virtual ICollection<WymDekretBufor> WymDekretBufors { get; set; } = new List<WymDekretBufor>();

    public virtual ICollection<WymDekretDziennik> WymDekretDzienniks { get; set; } = new List<WymDekretDziennik>();

    public virtual ICollection<WymDelegacja> WymDelegacjas { get; set; } = new List<WymDelegacja>();

    public virtual ICollection<WymDokumentElement> WymDokumentElements { get; set; } = new List<WymDokumentElement>();

    public virtual ICollection<WymDokumentNumerZapOfert> WymDokumentNumerZapOferts { get; set; } = new List<WymDokumentNumerZapOfert>();

    public virtual ICollection<WymDokumentNumer> WymDokumentNumers { get; set; } = new List<WymDokumentNumer>();

    public virtual ICollection<WymDokumentPlatnosc> WymDokumentPlatnoscs { get; set; } = new List<WymDokumentPlatnosc>();

    public virtual ICollection<WymDokumentSerium> WymDokumentSeria { get; set; } = new List<WymDokumentSerium>();

    public virtual ICollection<WymDokumentStatus> WymDokumentStatuses { get; set; } = new List<WymDokumentStatus>();

    public virtual ICollection<WymDokumentTyp> WymDokumentTyps { get; set; } = new List<WymDokumentTyp>();

    public virtual ICollection<WymDostawa> WymDostawas { get; set; } = new List<WymDostawa>();

    public virtual ICollection<WymDzialyGu> WymDzialyGus { get; set; } = new List<WymDzialyGu>();

    public virtual ICollection<WymEkspozycjeTowarow> WymEkspozycjeTowarows { get; set; } = new List<WymEkspozycjeTowarow>();

    public virtual ICollection<WymEtapProdukcji> WymEtapProdukcjis { get; set; } = new List<WymEtapProdukcji>();

    public virtual ICollection<WymFirma> WymFirmas { get; set; } = new List<WymFirma>();

    public virtual ICollection<WymFlotaTrasa> WymFlotaTrasas { get; set; } = new List<WymFlotaTrasa>();

    public virtual ICollection<WymFlotaUzytkownikStatus> WymFlotaUzytkownikStatuses { get; set; } = new List<WymFlotaUzytkownikStatus>();

    public virtual ICollection<WymFormyPlatnosciTyp> WymFormyPlatnosciTyps { get; set; } = new List<WymFormyPlatnosciTyp>();

    public virtual ICollection<WymFormyPlatnosci> WymFormyPlatnoscis { get; set; } = new List<WymFormyPlatnosci>();

    public virtual ICollection<WymFunkcje> WymFunkcjes { get; set; } = new List<WymFunkcje>();

    public virtual ICollection<WymGeografium> WymGeografia { get; set; } = new List<WymGeografium>();

    public virtual ICollection<WymGmina> WymGminas { get; set; } = new List<WymGmina>();

    public virtual ICollection<WymGrati> WymGratis { get; set; } = new List<WymGrati>();

    public virtual ICollection<WymJednostkaCzasu> WymJednostkaCzasus { get; set; } = new List<WymJednostkaCzasu>();

    public virtual ICollection<WymJednostka> WymJednostkas { get; set; } = new List<WymJednostka>();

    public virtual ICollection<WymKalkulacja> WymKalkulacjas { get; set; } = new List<WymKalkulacja>();

    public virtual ICollection<WymKategoriaAbcxyz> WymKategoriaAbcxyzs { get; set; } = new List<WymKategoriaAbcxyz>();

    public virtual ICollection<WymKategorieFinansowe> WymKategorieFinansowes { get; set; } = new List<WymKategorieFinansowe>();

    public virtual ICollection<WymKategorieRynkowe> WymKategorieRynkowes { get; set; } = new List<WymKategorieRynkowe>();

    public virtual ICollection<WymKierunekTel> WymKierunekTels { get; set; } = new List<WymKierunekTel>();

    public virtual ICollection<WymKodFiaska> WymKodFiaskas { get; set; } = new List<WymKodFiaska>();

    public virtual ICollection<WymKodZakonczenium> WymKodZakonczenia { get; set; } = new List<WymKodZakonczenium>();

    public virtual ICollection<WymKontakt> WymKontakts { get; set; } = new List<WymKontakt>();

    public virtual ICollection<WymKonto> WymKontos { get; set; } = new List<WymKonto>();

    public virtual ICollection<WymKontrahent> WymKontrahents { get; set; } = new List<WymKontrahent>();

    public virtual ICollection<WymKonwersacja> WymKonwersacjas { get; set; } = new List<WymKonwersacja>();

    public virtual ICollection<WymKosztyProdukcji> WymKosztyProdukcjis { get; set; } = new List<WymKosztyProdukcji>();

    public virtual ICollection<WymKraj> WymKrajs { get; set; } = new List<WymKraj>();

    public virtual ICollection<WymLimitTyp> WymLimitTyps { get; set; } = new List<WymLimitTyp>();

    public virtual ICollection<WymLimityKontrahentum> WymLimityKontrahenta { get; set; } = new List<WymLimityKontrahentum>();

    public virtual ICollection<WymLimityNieobecnosci> WymLimityNieobecnoscis { get; set; } = new List<WymLimityNieobecnosci>();

    public virtual ICollection<WymListyPlac> WymListyPlacs { get; set; } = new List<WymListyPlac>();

    public virtual ICollection<WymLokalizacja> WymLokalizacjas { get; set; } = new List<WymLokalizacja>();

    public virtual ICollection<WymLokatum> WymLokata { get; set; } = new List<WymLokatum>();

    public virtual ICollection<WymLokataStatus> WymLokataStatuses { get; set; } = new List<WymLokataStatus>();

    public virtual ICollection<WymLudnoscGrupyGu> WymLudnoscGrupyGus { get; set; } = new List<WymLudnoscGrupyGu>();

    public virtual ICollection<WymMagazyn> WymMagazyns { get; set; } = new List<WymMagazyn>();

    public virtual ICollection<WymMaterial> WymMaterials { get; set; } = new List<WymMaterial>();

    public virtual ICollection<WymMiejsceSkladowanium> WymMiejsceSkladowania { get; set; } = new List<WymMiejsceSkladowanium>();

    public virtual ICollection<WymMiejscowosc> WymMiejscowoscs { get; set; } = new List<WymMiejscowosc>();

    public virtual ICollection<WymNarzedzium> WymNarzedzia { get; set; } = new List<WymNarzedzium>();

    public virtual ICollection<WymNieobecnosc> WymNieobecnoscs { get; set; } = new List<WymNieobecnosc>();

    public virtual ICollection<WymObecnosc> WymObecnoscs { get; set; } = new List<WymObecnosc>();

    public virtual ICollection<WymObiektyProdukcji> WymObiektyProdukcjis { get; set; } = new List<WymObiektyProdukcji>();

    public virtual ICollection<WymObowiazywanie> WymObowiazywanies { get; set; } = new List<WymObowiazywanie>();

    public virtual ICollection<WymObraz> WymObrazs { get; set; } = new List<WymObraz>();

    public virtual ICollection<WymObszarKonwersacji> WymObszarKonwersacjis { get; set; } = new List<WymObszarKonwersacji>();

    public virtual ICollection<WymObszar> WymObszars { get; set; } = new List<WymObszar>();

    public virtual ICollection<WymOddzial> WymOddzials { get; set; } = new List<WymOddzial>();

    public virtual ICollection<WymOdpowiedz> WymOdpowiedzs { get; set; } = new List<WymOdpowiedz>();

    public virtual ICollection<WymOkresyObrachunkowe> WymOkresyObrachunkowes { get; set; } = new List<WymOkresyObrachunkowe>();

    public virtual ICollection<WymOperacjeReklamacji> WymOperacjeReklamacjis { get; set; } = new List<WymOperacjeReklamacji>();

    public virtual ICollection<WymOperatorTel> WymOperatorTels { get; set; } = new List<WymOperatorTel>();

    public virtual ICollection<WymOperator> WymOperators { get; set; } = new List<WymOperator>();

    public virtual ICollection<WymOsoba> WymOsobas { get; set; } = new List<WymOsoba>();

    public virtual ICollection<WymPartium> WymPartia { get; set; } = new List<WymPartium>();

    public virtual ICollection<WymPerspektywa> WymPerspektywas { get; set; } = new List<WymPerspektywa>();

    public virtual ICollection<WymPlacaSkladnik> WymPlacaSkladniks { get; set; } = new List<WymPlacaSkladnik>();

    public virtual ICollection<WymPlacaTyp> WymPlacaTyps { get; set; } = new List<WymPlacaTyp>();

    public virtual ICollection<WymPlecGu> WymPlecGus { get; set; } = new List<WymPlecGu>();

    public virtual ICollection<WymPomocniczy> WymPomocniczies { get; set; } = new List<WymPomocniczy>();

    public virtual ICollection<WymPowiat> WymPowiats { get; set; } = new List<WymPowiat>();

    public virtual ICollection<WymPracownikUmowy> WymPracownikUmowies { get; set; } = new List<WymPracownikUmowy>();

    public virtual ICollection<WymPracownik> WymPracowniks { get; set; } = new List<WymPracownik>();

    public virtual ICollection<WymPrecyzjaMiary> WymPrecyzjaMiaries { get; set; } = new List<WymPrecyzjaMiary>();

    public virtual ICollection<WymPreliminarz> WymPreliminarzs { get; set; } = new List<WymPreliminarz>();

    public virtual ICollection<WymProdProcesy> WymProdProcesies { get; set; } = new List<WymProdProcesy>();

    public virtual ICollection<WymProduktPozycjeDok> WymProduktPozycjeDoks { get; set; } = new List<WymProduktPozycjeDok>();

    public virtual ICollection<WymProdukt> WymProdukts { get; set; } = new List<WymProdukt>();

    public virtual ICollection<WymProjekt> WymProjekts { get; set; } = new List<WymProjekt>();

    public virtual ICollection<WymPromocjeTyp> WymPromocjeTyps { get; set; } = new List<WymPromocjeTyp>();

    public virtual ICollection<WymPromocje> WymPromocjes { get; set; } = new List<WymPromocje>();

    public virtual ICollection<WymPrzejazd> WymPrzejazds { get; set; } = new List<WymPrzejazd>();

    public virtual ICollection<WymPrzestojPriorytet> WymPrzestojPriorytets { get; set; } = new List<WymPrzestojPriorytet>();

    public virtual ICollection<WymPrzestojPrzyczyna> WymPrzestojPrzyczynas { get; set; } = new List<WymPrzestojPrzyczyna>();

    public virtual ICollection<WymPrzestojTyp> WymPrzestojTyps { get; set; } = new List<WymPrzestojTyp>();

    public virtual ICollection<WymPrzyczynaReklamacji> WymPrzyczynaReklamacjis { get; set; } = new List<WymPrzyczynaReklamacji>();

    public virtual ICollection<WymPytanie> WymPytanies { get; set; } = new List<WymPytanie>();

    public virtual ICollection<WymRabatRetro> WymRabatRetros { get; set; } = new List<WymRabatRetro>();

    public virtual ICollection<WymRaportyWizyt> WymRaportyWizyts { get; set; } = new List<WymRaportyWizyt>();

    public virtual ICollection<WymRealizacjeReklamacji> WymRealizacjeReklamacjis { get; set; } = new List<WymRealizacjeReklamacji>();

    public virtual ICollection<WymReceptury> WymRecepturies { get; set; } = new List<WymReceptury>();

    public virtual ICollection<WymRejon> WymRejons { get; set; } = new List<WymRejon>();

    public virtual ICollection<WymRezerwacjaNumer> WymRezerwacjaNumers { get; set; } = new List<WymRezerwacjaNumer>();

    public virtual ICollection<WymRezerwacjaTyp> WymRezerwacjaTyps { get; set; } = new List<WymRezerwacjaTyp>();

    public virtual ICollection<WymRodzKosztuDod> WymRodzKosztuDods { get; set; } = new List<WymRodzKosztuDod>();

    public virtual ICollection<WymRodzajCeny> WymRodzajCenies { get; set; } = new List<WymRodzajCeny>();

    public virtual ICollection<WymRodzajKlucza> WymRodzajKluczas { get; set; } = new List<WymRodzajKlucza>();

    public virtual ICollection<WymRodzajKosztuCrm> WymRodzajKosztuCrms { get; set; } = new List<WymRodzajKosztuCrm>();

    public virtual ICollection<WymRodzajKosztuSprzedazy> WymRodzajKosztuSprzedazies { get; set; } = new List<WymRodzajKosztuSprzedazy>();

    public virtual ICollection<WymRodzajKosztu> WymRodzajKosztus { get; set; } = new List<WymRodzajKosztu>();

    public virtual ICollection<WymRodzajUboczny> WymRodzajUbocznies { get; set; } = new List<WymRodzajUboczny>();

    public virtual ICollection<WymRodzajWydatku> WymRodzajWydatkus { get; set; } = new List<WymRodzajWydatku>();

    public virtual ICollection<WymRodzajZakupu> WymRodzajZakupus { get; set; } = new List<WymRodzajZakupu>();

    public virtual ICollection<WymRozmowcaNazwaTel> WymRozmowcaNazwaTels { get; set; } = new List<WymRozmowcaNazwaTel>();

    public virtual ICollection<WymRozmowcaNumerTel> WymRozmowcaNumerTels { get; set; } = new List<WymRozmowcaNumerTel>();

    public virtual ICollection<WymRozmowcaRodzajTel> WymRozmowcaRodzajTels { get; set; } = new List<WymRozmowcaRodzajTel>();

    public virtual ICollection<WymRozpatrzenieReklamacji> WymRozpatrzenieReklamacjis { get; set; } = new List<WymRozpatrzenieReklamacji>();

    public virtual ICollection<WymSamochod> WymSamochods { get; set; } = new List<WymSamochod>();

    public virtual ICollection<WymSekcjeGu> WymSekcjeGus { get; set; } = new List<WymSekcjeGu>();

    public virtual ICollection<WymSpodziewanaZapadalnosc2> WymSpodziewanaZapadalnosc2s { get; set; } = new List<WymSpodziewanaZapadalnosc2>();

    public virtual ICollection<WymSpodziewanaZapadalnoscTyp> WymSpodziewanaZapadalnoscTyps { get; set; } = new List<WymSpodziewanaZapadalnoscTyp>();

    public virtual ICollection<WymSpodziewanaZapadalnosc> WymSpodziewanaZapadalnoscs { get; set; } = new List<WymSpodziewanaZapadalnosc>();

    public virtual ICollection<WymSposobDostawy> WymSposobDostawies { get; set; } = new List<WymSposobDostawy>();

    public virtual ICollection<WymSprawy> WymSprawies { get; set; } = new List<WymSprawy>();

    public virtual ICollection<WymSrodekTrwaly> WymSrodekTrwalies { get; set; } = new List<WymSrodekTrwaly>();

    public virtual ICollection<WymStanKontrahentum> WymStanKontrahenta { get; set; } = new List<WymStanKontrahentum>();

    public virtual ICollection<WymStanZamowienium> WymStanZamowienia { get; set; } = new List<WymStanZamowienium>();

    public virtual ICollection<WymStatusProdukcji> WymStatusProdukcjis { get; set; } = new List<WymStatusProdukcji>();

    public virtual ICollection<WymStawkiVat> WymStawkiVats { get; set; } = new List<WymStawkiVat>();

    public virtual ICollection<WymStazKlientum> WymStazKlienta { get; set; } = new List<WymStazKlientum>();

    public virtual ICollection<WymStazKlientaTyp> WymStazKlientaTyps { get; set; } = new List<WymStazKlientaTyp>();

    public virtual ICollection<WymStazPracownika> WymStazPracownikas { get; set; } = new List<WymStazPracownika>();

    public virtual ICollection<WymStrefaTel> WymStrefaTels { get; set; } = new List<WymStrefaTel>();

    public virtual ICollection<WymStrukturaFirmy> WymStrukturaFirmies { get; set; } = new List<WymStrukturaFirmy>();

    public virtual ICollection<WymStrukturaPraw> WymStrukturaPraws { get; set; } = new List<WymStrukturaPraw>();

    public virtual ICollection<WymTechnologium> WymTechnologia { get; set; } = new List<WymTechnologium>();

    public virtual ICollection<WymTerminWaznosciTyp> WymTerminWaznosciTyps { get; set; } = new List<WymTerminWaznosciTyp>();

    public virtual ICollection<WymTerminWaznosci> WymTerminWaznoscis { get; set; } = new List<WymTerminWaznosci>();

    public virtual ICollection<WymTrasa> WymTrasas { get; set; } = new List<WymTrasa>();

    public virtual ICollection<WymTypKontrahentaEtap> WymTypKontrahentaEtaps { get; set; } = new List<WymTypKontrahentaEtap>();

    public virtual ICollection<WymTypZamowienium> WymTypZamowienia { get; set; } = new List<WymTypZamowienium>();

    public virtual ICollection<WymTypZasobu> WymTypZasobus { get; set; } = new List<WymTypZasobu>();

    public virtual ICollection<WymUmowaDniDoKonca> WymUmowaDniDoKoncas { get; set; } = new List<WymUmowaDniDoKonca>();

    public virtual ICollection<WymUmowaElement> WymUmowaElements { get; set; } = new List<WymUmowaElement>();

    public virtual ICollection<WymUmowaStatus> WymUmowaStatuses { get; set; } = new List<WymUmowaStatus>();

    public virtual ICollection<WymUmowa> WymUmowas { get; set; } = new List<WymUmowa>();

    public virtual ICollection<WymWalutum> WymWaluta { get; set; } = new List<WymWalutum>();

    public virtual ICollection<WymWizyty> WymWizyties { get; set; } = new List<WymWizyty>();

    public virtual ICollection<WymWizytyElement> WymWizytyElements { get; set; } = new List<WymWizytyElement>();

    public virtual ICollection<WymWmsmagazyn> WymWmsmagazyns { get; set; } = new List<WymWmsmagazyn>();

    public virtual ICollection<WymWmsstrukturaMagazynu> WymWmsstrukturaMagazynus { get; set; } = new List<WymWmsstrukturaMagazynu>();

    public virtual ICollection<WymWniosek> WymWnioseks { get; set; } = new List<WymWniosek>();

    public virtual ICollection<WymWojewodztwo> WymWojewodztwos { get; set; } = new List<WymWojewodztwo>();

    public virtual ICollection<WymWygasanieTyp> WymWygasanieTyps { get; set; } = new List<WymWygasanieTyp>();

    public virtual ICollection<WymWygasanie> WymWygasanies { get; set; } = new List<WymWygasanie>();

    public virtual ICollection<WymWymiaryAnalityczne> WymWymiaryAnalitycznes { get; set; } = new List<WymWymiaryAnalityczne>();

    public virtual ICollection<WymWyplataKategorium> WymWyplataKategoria { get; set; } = new List<WymWyplataKategorium>();

    public virtual ICollection<WymZadanieReklamujacego> WymZadanieReklamujacegos { get; set; } = new List<WymZadanieReklamujacego>();

    public virtual ICollection<WymZadanie> WymZadanies { get; set; } = new List<WymZadanie>();

    public virtual ICollection<WymZaleganieTyp> WymZaleganieTyps { get; set; } = new List<WymZaleganieTyp>();

    public virtual ICollection<WymZaleganie> WymZaleganies { get; set; } = new List<WymZaleganie>();

    public virtual ICollection<WymZamowieniaStan> WymZamowieniaStans { get; set; } = new List<WymZamowieniaStan>();

    public virtual ICollection<WymZapadalnosc2> WymZapadalnosc2s { get; set; } = new List<WymZapadalnosc2>();

    public virtual ICollection<WymZapadalnoscTyp> WymZapadalnoscTyps { get; set; } = new List<WymZapadalnoscTyp>();

    public virtual ICollection<WymZapadalnosc> WymZapadalnoscs { get; set; } = new List<WymZapadalnosc>();

    public virtual ICollection<WymZasob> WymZasobs { get; set; } = new List<WymZasob>();

    public virtual ICollection<WymZestawienium> WymZestawienia { get; set; } = new List<WymZestawienium>();

    public virtual ICollection<WymZestawieniaInkrementalnie> WymZestawieniaInkrementalnies { get; set; } = new List<WymZestawieniaInkrementalnie>();

    public virtual ICollection<WymZestawieniaStruktura> WymZestawieniaStrukturas { get; set; } = new List<WymZestawieniaStruktura>();

    public virtual ICollection<WymZestawieniaZmienne> WymZestawieniaZmiennes { get; set; } = new List<WymZestawieniaZmienne>();
}
