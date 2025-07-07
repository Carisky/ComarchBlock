using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktKoszty
{
    /// <summary>
    /// Identyfikator daty spinacza dokumentu, lub dokumentu kiedy nie posiada on spinacza. Relacja do wymiaru WYM_CzasMiesiac
    /// </summary>
    public int KosztCzmid { get; set; }

    /// <summary>
    /// Identyfikator firmy. Relacja do wymiaru WYM_Firma
    /// </summary>
    public int KosztFirmaId { get; set; }

    /// <summary>
    /// Data wystawienia dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int? KosztCzwid { get; set; }

    /// <summary>
    /// Identyfikator akwizytora. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int KosztAkwId { get; set; }

    /// <summary>
    /// Identyfikator etapu kampanii CRM. Relacja do wymiaru WYM_CRMEtap
    /// </summary>
    public int KosztCrmetapId { get; set; }

    /// <summary>
    /// Godzina wystawienia dokumentu. Relacja do wymiaru WYM_CzasGodzina
    /// </summary>
    public int? KosztCzgid { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta głównego.Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int KosztKntId { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public int? KosztPlatDokNumerId { get; set; }

    /// <summary>
    /// Identyfikator formy płatności zdefiniowanej na dokumencie. Relacja do wymiaru WYM_FormyPlatnosci
    /// </summary>
    public int KosztFormaPlatId { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int KosztCechyId { get; set; }

    /// <summary>
    /// Identyfikator jednostki podstawowej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int KosztJmId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int KosztBudzetId { get; set; }

    /// <summary>
    /// Identyfikator kategorii finansowej przypisanej do dokumentu. Relacja do wymiaru WYM_KategorieFinansowe
    /// </summary>
    public int KosztKatFinId { get; set; }

    /// <summary>
    /// Identyfikator stazu akwizytora.Relacja do wymiaru WYM_StazKlienta
    /// </summary>
    public int KosztAkwStazId { get; set; }

    /// <summary>
    /// Identyfikator dostawcy. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int KosztDstId { get; set; }

    /// <summary>
    /// Identyfikator stazu kontrahenta docelowego (odbiorcy). Relacja do wymiaru WYM_StazKlienta
    /// </summary>
    public int KosztKndStazId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta docelowego (odbiorcy) . Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int KosztKndId { get; set; }

    /// <summary>
    /// Identyfikator jednostki pomocniczej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int KosztJmpId { get; set; }

    /// <summary>
    /// Identyfikator rodzaju kosztu sprzedaży. Relacja do wymiaru WYM_RodzajKosztuSprzedazy
    /// </summary>
    public int KosztRksId { get; set; }

    /// <summary>
    /// Identyfikator spinacza dokumentu. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int KosztSpiNumerId { get; set; }

    /// <summary>
    /// Identyfikator projektu. Relacja do wymiaru WYM_Projekt
    /// </summary>
    public int KosztProjektId { get; set; }

    /// <summary>
    /// Identyfikator stażu towaru. Relacja do wymiaru WYM_StazKlienta
    /// </summary>
    public int KosztProdStazId { get; set; }

    /// <summary>
    /// Identyfikator Daty Dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int KosztDataDokumentuId { get; set; }

    /// <summary>
    /// Identyfikator waluty. Relacja do wymiaru WYM_Waluta
    /// </summary>
    public int KosztWalutaId { get; set; }

    /// <summary>
    /// Identyfikator numeru dokumentu handlowego. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int KosztDokNumerId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_StrukturaPraw
    /// </summary>
    public int KosztStrPrwId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_StrukturaFirmy
    /// </summary>
    public int KosztStrFrmId { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public int KosztMsklId { get; set; }

    /// <summary>
    /// Identyfikator opiekuna kontrahenta. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int KosztOpiekunId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Perspektywa
    /// </summary>
    public int KosztPerspektywaId { get; set; }

    /// <summary>
    /// Identyfikator stazu kontrahenta głównego. Relacja do wymiaru WYM_StazKlienta
    /// </summary>
    public int KosztKntStazId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Lokalizacja
    /// </summary>
    public int KosztLokId { get; set; }

    /// <summary>
    /// Identyfikator magazynu dla danego towaru. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int KosztMagId { get; set; }

    /// <summary>
    /// Identyfikator płatnika. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int KosztPlatId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int KosztProdId { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public int KosztPracownikId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long KosztId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int KosztZrodgid { get; set; }

    /// <summary>
    /// Identyfikator daty spinacza dokumentu, lub dokumentu kiedy nie posiada on spinacza. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int KosztCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KosztOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KosztDirtyOrgId { get; set; } = null!;

    public string? KosztOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int KosztUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KosztUpdateSubTransformationId { get; set; }

    public int KosztInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KosztInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KosztTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KosztTsupdate { get; set; }

    /// <summary>
    /// Wartość kosztu rozbita procentowo
    /// </summary>
    public decimal? KosztMkoszt { get; set; }

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public int? KosztPaczka { get; set; }

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public int? KosztKierunek { get; set; }

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public string? KosztOrgWymId { get; set; }

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public string? KosztOrgAtrId { get; set; }

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public int? KosztWymTyp { get; set; }

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public string? KosztWymObjGidLp { get; set; }

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public int? KosztTypKwoty { get; set; }

    /// <summary>
    /// Calkowita wartość kosztu
    /// </summary>
    public decimal? KosztMkosztCalosc { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? KosztRejonId { get; set; }

    /// <summary>
    /// Identyfikator daty sprzedaży/zakupu w zależności od rodzaju dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int KosztCzsid { get; set; }

    /// <summary>
    /// Identyfikator adresu Kontrahenta Docelowego. Relacja do wymiaru WYM_Adres
    /// </summary>
    public int? KosztAdrKndId { get; set; }

    /// <summary>
    /// Identyfikator użytego cennika. Relacja do wymiaru WYM_Cennik
    /// </summary>
    public int KosztCennikId { get; set; }

    /// <summary>
    /// Identyfikator numeru dokumentu wysyłki. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int KosztDokWysylkiId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int KosztAlokacjaId { get; set; }

    public string? KosztOrgAtrEleId { get; set; }

    public string? KosztOrgAtrNagId { get; set; }

    public string? KosztOrgAtrSubId { get; set; }

    public bool? KosztIsCorrection { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int KosztPrmgid { get; set; }

    public decimal? SprzedazKosztyBdtcalc { get; set; }

    /// <summary>
    /// Relacja do wymiaru RodzajCeny
    /// </summary>
    public int KosztRodzCenId { get; set; }

    public string? KosztDataMod { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Atr0212Id { get; set; }

    public int? Atr0213Id { get; set; }

    public int? Atr0237Id { get; set; }

    public int? Atr0238Id { get; set; }

    public int? Atr0239Id { get; set; }

    public int? Atr0240Id { get; set; }

    public int? Atr0241Id { get; set; }

    public int? Atr0248Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int? Wym02139Id { get; set; }

    public int? Wym02142Id { get; set; }

    public int? Atr0242Id { get; set; }

    public int? Atr0267Id { get; set; }

    public int? Atr027Id { get; set; }

    public int? Atr028Id { get; set; }

    public int? Atr029Id { get; set; }

    public int KosztCzdterminPlatId { get; set; }

    public int? Atr02101Id { get; set; }

    public virtual WymAdre? KosztAdrKnd { get; set; }

    public virtual WymKontrahent KosztAkw { get; set; } = null!;

    public virtual WymStazKlientum KosztAkwStaz { get; set; } = null!;

    public virtual WymAlokacja KosztAlokacja { get; set; } = null!;

    public virtual WymBudzet KosztBudzet { get; set; } = null!;

    public virtual WymCechy KosztCechy { get; set; } = null!;

    public virtual WymCennik KosztCennik { get; set; } = null!;

    public virtual WymCrmetapy KosztCrmetap { get; set; } = null!;

    public virtual WymCzasDzien KosztCzd { get; set; } = null!;

    public virtual WymCzasDzien KosztCzdterminPlat { get; set; } = null!;

    public virtual WymCzasGodzina? KosztCzg { get; set; }

    public virtual WymCzasMiesiac KosztCzm { get; set; } = null!;

    public virtual WymCzasDzien KosztCzs { get; set; } = null!;

    public virtual WymCzasDzien? KosztCzw { get; set; }

    public virtual WymCzasDzien KosztDataDokumentu { get; set; } = null!;

    public virtual WymDokumentNumer KosztDokNumer { get; set; } = null!;

    public virtual WymDokumentNumer KosztDokWysylki { get; set; } = null!;

    public virtual WymKontrahent KosztDst { get; set; } = null!;

    public virtual WymFirma KosztFirma { get; set; } = null!;

    public virtual WymFormyPlatnosci KosztFormaPlat { get; set; } = null!;

    public virtual WymJednostka KosztJm { get; set; } = null!;

    public virtual WymJednostka KosztJmp { get; set; } = null!;

    public virtual WymKategorieFinansowe KosztKatFin { get; set; } = null!;

    public virtual WymKontrahent KosztKnd { get; set; } = null!;

    public virtual WymStazKlientum KosztKndStaz { get; set; } = null!;

    public virtual WymKontrahent KosztKnt { get; set; } = null!;

    public virtual WymStazKlientum KosztKntStaz { get; set; } = null!;

    public virtual WymLokalizacja KosztLok { get; set; } = null!;

    public virtual WymMagazyn KosztMag { get; set; } = null!;

    public virtual WymMiejsceSkladowanium KosztMskl { get; set; } = null!;

    public virtual WymPracownik KosztOpiekun { get; set; } = null!;

    public virtual WymPerspektywa KosztPerspektywa { get; set; } = null!;

    public virtual WymKontrahent KosztPlat { get; set; } = null!;

    public virtual WymDokumentNumer? KosztPlatDokNumer { get; set; }

    public virtual WymPracownik KosztPracownik { get; set; } = null!;

    public virtual WymPrecyzjaMiary KosztPrmg { get; set; } = null!;

    public virtual WymProdukt KosztProd { get; set; } = null!;

    public virtual WymStazKlientum KosztProdStaz { get; set; } = null!;

    public virtual WymProjekt KosztProjekt { get; set; } = null!;

    public virtual WymRejon? KosztRejon { get; set; }

    public virtual WymRodzajKosztuSprzedazy KosztRks { get; set; } = null!;

    public virtual WymRodzajCeny KosztRodzCen { get; set; } = null!;

    public virtual WymDokumentNumer KosztSpiNumer { get; set; } = null!;

    public virtual WymStrukturaFirmy KosztStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw KosztStrPrw { get; set; } = null!;

    public virtual WymWalutum KosztWaluta { get; set; } = null!;

    public virtual WymZrodloDanych KosztZrodg { get; set; } = null!;
}
