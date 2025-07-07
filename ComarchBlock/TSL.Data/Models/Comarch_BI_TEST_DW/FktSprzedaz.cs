using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktSprzedaz
{
    /// <summary>
    /// Opis. Pole systemowe
    /// </summary>
    public string? SprDescription { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SprDirtyOrgId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long SprId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SprInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string SprOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SprSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime SprTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime SprTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Identyfikator Akwizytora. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int SprAkwId { get; set; }

    /// <summary>
    /// Identyfikator stazu akwizytora.Relacja do wymiaru WYM_StazKlienta
    /// </summary>
    public int SprAkwStazId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int SprBudzetId { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int SprCechyId { get; set; }

    /// <summary>
    /// Identyfikator etapu kampanii CRM. Relacja do wymiaru WYM_CRMEtap
    /// </summary>
    public int SprCrmetapId { get; set; }

    /// <summary>
    /// Identyfikator daty spinacza dokumentu, lub dokumentu kiedy nie posiada on spinacza. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int SprCzdid { get; set; }

    /// <summary>
    /// Identyfikator daty spinacza dokumentu, lub dokumentu kiedy nie posiada on spinacza. Relacja do wymiaru WYM_CzasMiesiac
    /// </summary>
    public int SprCzmid { get; set; }

    /// <summary>
    /// Identyfikator numeru dokumentu. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int SprDokNumerId { get; set; }

    /// <summary>
    /// Identyfikator dostawcy. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int SprDstId { get; set; }

    /// <summary>
    /// Identyfikator firmy. Relacja do wymiaru WYM_Firma
    /// </summary>
    public int SprFirmaId { get; set; }

    /// <summary>
    /// Identyfikator jednostki pomocniczej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int SprJmpId { get; set; }

    /// <summary>
    /// Identyfikator kategorii finansowej przypisanej do dokumentu. Relacja do wymiaru WYM_KategorieFinansowe
    /// </summary>
    public int SprKatFinId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta docelowego (odbiorcy) . Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int SprKndId { get; set; }

    /// <summary>
    /// Identyfikator stazu kontrahenta docelowego (odbiorcy). Relacja do wymiaru WYM_StazKlienta
    /// </summary>
    public int SprKndStazId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta głównego.Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int SprKntId { get; set; }

    /// <summary>
    /// Identyfikator stazu kontrahenta głównego. Relacja do wymiaru WYM_StazKlienta
    /// </summary>
    public int SprKntStazId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Lokalizacja
    /// </summary>
    public int SprLokId { get; set; }

    /// <summary>
    /// Identyfikator magazynu dla danego towaru. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int SprMagId { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public int SprMsklId { get; set; }

    /// <summary>
    /// Identyfikator opiekuna kontrahenta. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int SprOpiekunId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Perspektywa
    /// </summary>
    public int SprPerspektywaId { get; set; }

    /// <summary>
    /// Identyfikator płatnika. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int SprPlatId { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public int SprPracownikId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int SprProdId { get; set; }

    /// <summary>
    /// Identyfikator stażu towaru. Relacja do wymiaru WYM_StazKlienta
    /// </summary>
    public int SprProdStazId { get; set; }

    /// <summary>
    /// Identyfikator projektu. Relacja do wymiaru WYM_Projekt
    /// </summary>
    public int SprProjektId { get; set; }

    /// <summary>
    /// Identyfikator spinacza dokumentu. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int SprSpiNumerId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_StrukturaFirmy
    /// </summary>
    public int SprStrFrmId { get; set; }

    /// <summary>
    /// Identyfikator waluty użytej na dokumencie. Relacja do wymiaru WYM_Waluta
    /// </summary>
    public int SprWalutaId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int SprZrodgid { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? SprMakwStaz { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? SprMdstStaz { get; set; }

    /// <summary>
    /// Ilość, na jaką opiewa transakcja
    /// </summary>
    public decimal? SprMilosc { get; set; }

    /// <summary>
    /// Ilość w jednostce pomocniczej
    /// </summary>
    public decimal? SprMiloscJmp { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? SprMkndStaz { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? SprMkntStaz { get; set; }

    /// <summary>
    /// Wartość księgowa kosztu pobrana z subelementu
    /// </summary>
    public decimal? SprMkoszt { get; set; }

    /// <summary>
    /// Uzyskana marża
    /// </summary>
    public decimal? SprMmarza { get; set; }

    /// <summary>
    /// Objętość towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? SprMobjetosc { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? SprMplatStaz { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? SprMprodStaz { get; set; }

    /// <summary>
    /// Przychód ze sprzedaży netto wyrażony w walucie systemowej, pobrany z subelementu
    /// </summary>
    public decimal? SprMprzychod { get; set; }

    /// <summary>
    /// Ilość punktów w programie lojalnościowym dla pozycji dokumentu
    /// </summary>
    public decimal? SprMpunkty { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? SprMspiIlosc { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? SprMspiKoszt { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? SprMspiPrzychod { get; set; }

    /// <summary>
    /// Kolumna pomocnicza dla mechanizmu korekty zaokrągleń. Ilość towaru w jednostkach podstawowych
    /// </summary>
    public decimal? SprMtreIlosc { get; set; }

    /// <summary>
    /// Kolumna pomocnicza dla mechanizmu korekty zaokrągleń. Wartość księgowa kosztu pobrana z elementu
    /// </summary>
    public decimal? SprMtreKoszt { get; set; }

    /// <summary>
    /// Kolumna pomocnicza dla mechanizmu korekty zaokrągleń. Wartość księgowa netto pobrana z elementu
    /// </summary>
    public decimal? SprMtrePrzychod { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? SprMtrnIlosc { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? SprMtrnKoszt { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? SprMtrnPrzychod { get; set; }

    /// <summary>
    /// Waga towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? SprMwaga { get; set; }

    /// <summary>
    /// Informacja, czy dokument został anulowany
    /// </summary>
    public int? SprAnulowany { get; set; }

    /// <summary>
    /// Data wystawienia dokumentu wyrażona w formacie Clarion
    /// </summary>
    public int? SprDataWystawienia { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public int? SprDstStazId { get; set; }

    /// <summary>
    /// Kierunek dokumentu, dla dokumentów sprzedażowych wszystkie poza Korektą Kosztu mają kierunek 1
    /// </summary>
    public int? SprKierunek { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public int? SprObjGidLp { get; set; }

    public string? SprOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SprOrgWid { get; set; }

    /// <summary>
    /// Identyfiaktor opisu analitycznego
    /// </summary>
    public string? SprOrgWymId { get; set; }

    /// <summary>
    /// Pole pomocnicze
    /// </summary>
    public int? SprPaczka { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public int? SprPlatStazId { get; set; }

    /// <summary>
    /// Pozycja na dokumencie
    /// </summary>
    public int? SprPozycjaId { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public string? SprPrzelicznikWaluty { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public int? SprTypKwoty { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SprUpdateTransformationId { get; set; }

    public string? SprWymObjGidLp { get; set; }

    public int? SprWymTyp { get; set; }

    /// <summary>
    /// Przychód ze sprzedaży netto wyrażony w walucie dokumentu, pobrany z subelementu
    /// </summary>
    public decimal? SprMprzychodWaluta { get; set; }

    /// <summary>
    /// Data wystawienia dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int? SprCzwid { get; set; }

    /// <summary>
    /// Identyfikator jednostki podstawowej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int SprJmPodstId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_StrukturaPraw
    /// </summary>
    public int SprStrPrwId { get; set; }

    /// <summary>
    /// Identyfikator formy płatności zdefiniowanej na dokumencie. Relacja do wymiaru WYM_FormyPlatnosci
    /// </summary>
    public int SprFormPlatId { get; set; }

    /// <summary>
    /// Ilość w jednostce podstawowej
    /// </summary>
    public decimal? SprMiloscJmPodst { get; set; }

    /// <summary>
    /// Godzina wystawienia dokumentu. Relacja do wymiaru WYM_CzasGodzina
    /// </summary>
    public int? SprCzgid { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public int? SprPlatDokNumerId { get; set; }

    /// <summary>
    /// Przychód ze sprzedaży brutto wyrażony w walucie systemowej, pobrany z subelementu
    /// </summary>
    public decimal? SprMprzychodBrutto { get; set; }

    /// <summary>
    /// Kolumna pomocnicza dla mechanizmu korekty zaokrągleń. Wartość księgowa brutto pobrana z elementu wyrażona w walucie systemowej
    /// </summary>
    public decimal? SprMtrePrzychodBrutto { get; set; }

    /// <summary>
    /// Identyfikator Daty Dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int SprDataDokumentuId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza dla mechanizmu korekty zaokrągleń. Wartość księgowa brutto pobrana z elementu wyrażona w walucie dokumentu
    /// </summary>
    public decimal? SprMtrePrzychodWaluta { get; set; }

    /// <summary>
    /// Wartość KGO dla elementu
    /// </summary>
    public decimal? SprMkgo { get; set; }

    /// <summary>
    /// Numer subelementu
    /// </summary>
    public int? SprSubPozycjaId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int SprRejonId { get; set; }

    /// <summary>
    /// Identyfikator daty sprzedaży/zakupu w zależności od rodzaju dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int SprCzsid { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_RodzajKosztuSprzedazy
    /// </summary>
    public int SprRksid { get; set; }

    /// <summary>
    /// Identyfikator terminu płatności pobranego z nagłówka dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int? SprCzdterminPlatId { get; set; }

    /// <summary>
    /// Identyfikator opiekuna kontrahenta, pobrany z dokumentu spiętego. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int SprOpiekunSpinaczId { get; set; }

    /// <summary>
    /// Identyfikator adresu Kontrahenta Docelowego. Relacja do wymiaru WYM_Adres
    /// </summary>
    public int? SprAdrKndId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Cennik
    /// </summary>
    public int SprCennikId { get; set; }

    /// <summary>
    /// Cena począątkowa w walucie dokumentu
    /// </summary>
    public decimal? SprMcenaBazowa { get; set; }

    /// <summary>
    /// Informacja, czy został udzielony rabat
    /// </summary>
    public decimal SprCzyRabat { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Geografia
    /// </summary>
    public int SprGeoid { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int SprAlokacjaId { get; set; }

    /// <summary>
    /// Informacja czy produkt ma flagę &apos;Gratis&apos; lub &apos;Złom&apos;. Relacja do wymiaru WYM_ProduktPozycjeDok
    /// </summary>
    public int SprProduktPozycjeDokId { get; set; }

    /// <summary>
    /// Identyfikator kategorii ABC\XYZ przypisanej towarowi. Relacja do wymiaru WYM_KategoriaABCXYZ
    /// </summary>
    public int SprAbcid { get; set; }

    /// <summary>
    /// Identyfikator dostawy towaru. Relacja do wymiaru WYM_Dostawa
    /// </summary>
    public int SprDostId { get; set; }

    /// <summary>
    /// Kolumna wskazuje czy dany wiersz pochodzi z dokumentu korekty lub nie (0/1).
    /// </summary>
    public bool? SprIsCorrection { get; set; }

    public string? SprOrgAtrEleId { get; set; }

    public string? SprOrgAtrNagId { get; set; }

    public string? SprOrgAtrSubId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza dla mechanizmu korekty zaokrągleń. Wartość księgowa brutto pobrana z nagłówka dokumentu wyrażona w walucie systemowej
    /// </summary>
    public decimal? SprMtrnPrzychodBrutto { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int SprPrmgid { get; set; }

    /// <summary>
    /// Koszt rzeczywisty pobrany z subelementu
    /// </summary>
    public decimal? SprMkosztRzeczywisty { get; set; }

    public decimal? SprzedazMarzaRzeczywistaBdtcalc { get; set; }

    public decimal? SprzedazWartoscPrzedRabatemBdtcalc { get; set; }

    /// <summary>
    /// Relation to dimension LimityKontrahenta
    /// </summary>
    public int SprKlkgid { get; set; }

    /// <summary>
    /// Cena począątkowa w walucie dokumentu spinacz elementów
    /// </summary>
    public decimal? SprMcenaBazowaSpinacz { get; set; }

    /// <summary>
    /// Ilość w jednostce podstawowej na dokumencie sinacz elementów
    /// </summary>
    public decimal? SprMiloscJmPodstSpinacz { get; set; }

    /// <summary>
    /// Ilość w jednostce pomocniczej na spinaczy elementów
    /// </summary>
    public decimal? SprMiloscJmpSpinacz { get; set; }

    /// <summary>
    /// Ilość, na jaką opiewa transakcja
    /// </summary>
    public decimal? SprMiloscSpinacz { get; set; }

    /// <summary>
    /// Koszt rzeczywisty pobrany z subelementu na spinaczu elementów
    /// </summary>
    public decimal? SprMkosztRzeczywistySpinacz { get; set; }

    /// <summary>
    /// Wartość księgowa kosztu pobrana z subelementu spinacza elementów
    /// </summary>
    public decimal? SprMkosztSpinacz { get; set; }

    /// <summary>
    /// Uzyskana marża
    /// </summary>
    public decimal? SprMmarzaSpinacz { get; set; }

    /// <summary>
    /// Objętość towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? SprMobjetoscSpinacz { get; set; }

    /// <summary>
    /// Przychód ze sprzedaży brutto wyrażony w walucie systemowej, pobrany z subelementu spinacza elementów
    /// </summary>
    public decimal? SprMprzychodBruttoSpinacz { get; set; }

    /// <summary>
    /// Przychód ze sprzedaży netto wyrażony w walucie systemowej, pobrany z subelementu
    /// </summary>
    public decimal? SprMprzychodSpinacz { get; set; }

    /// <summary>
    /// Przychód ze sprzedaży netto wyrażony w walucie dokumentu, pobrany z subelementu
    /// </summary>
    public decimal? SprMprzychodWalutaSpinacz { get; set; }

    /// <summary>
    /// Waga towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? SprMwagaSpinacz { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_RodzajCeny
    /// </summary>
    public int SprRodzCenId { get; set; }

    /// <summary>
    /// Ilość punktów w programie lojalnościowym dla nagłówka dokumentu
    /// </summary>
    public decimal? SprMtrNpunkty { get; set; }

    /// <summary>
    /// Czy pozycja jest nagrodą w programie lojalnościowym
    /// </summary>
    public int? SprTreNagroda { get; set; }

    /// <summary>
    /// Identyfikator daty rozliczenia pobranej z nagłówka dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int SprCzddataRozId { get; set; }

    /// <summary>
    /// Relation to dimension FormyPlatnosci
    /// </summary>
    public int SprFormPlatSpiId { get; set; }

    public string? SprDataMod { get; set; }

    public int SprCzdprzyjeciaWydaniaId { get; set; }

    public int SprOpeid { get; set; }

    public int SprOpemid { get; set; }

    public int SprOpewid { get; set; }

    public int SprOpezid { get; set; }

    public decimal? SprMprzychodSpinaczHandlowy { get; set; }

    public decimal? SprMdniWaznosci { get; set; }

    public int SprWaznoscId { get; set; }

    public decimal? SprMiloscZaliczki { get; set; }

    public decimal? SprMwartoscZaliczki { get; set; }

    public decimal? SprMoplataCukrowaSuma { get; set; }

    public decimal? SprMoplataCukrowaIloscWmililitrach { get; set; }

    public int SprDokElemId { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Atr0212Id { get; set; }

    public int? Atr0237Id { get; set; }

    public int? Atr0238Id { get; set; }

    public int? Atr0239Id { get; set; }

    public int? Atr0240Id { get; set; }

    public int? Atr0241Id { get; set; }

    public int? Atr0248Id { get; set; }

    public int? Atr0213Id { get; set; }

    public decimal? Atrm021320331Id { get; set; }

    public decimal? Atrm021320371Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public virtual WymKategoriaAbcxyz SprAbc { get; set; } = null!;

    public virtual WymAdre? SprAdrKnd { get; set; }

    public virtual WymKontrahent SprAkw { get; set; } = null!;

    public virtual WymStazKlientum SprAkwStaz { get; set; } = null!;

    public virtual WymAlokacja SprAlokacja { get; set; } = null!;

    public virtual WymBudzet SprBudzet { get; set; } = null!;

    public virtual WymCechy SprCechy { get; set; } = null!;

    public virtual WymCennik SprCennik { get; set; } = null!;

    public virtual WymCrmetapy SprCrmetap { get; set; } = null!;

    public virtual WymCzasDzien SprCzd { get; set; } = null!;

    public virtual WymCzasDzien SprCzddataRoz { get; set; } = null!;

    public virtual WymCzasDzien SprCzdprzyjeciaWydania { get; set; } = null!;

    public virtual WymCzasDzien? SprCzdterminPlat { get; set; }

    public virtual WymCzasGodzina? SprCzg { get; set; }

    public virtual WymCzasMiesiac SprCzm { get; set; } = null!;

    public virtual WymCzasDzien SprCzs { get; set; } = null!;

    public virtual WymCzasDzien? SprCzw { get; set; }

    public virtual WymCzasDzien SprDataDokumentu { get; set; } = null!;

    public virtual WymDokumentElement SprDokElem { get; set; } = null!;

    public virtual WymDokumentNumer SprDokNumer { get; set; } = null!;

    public virtual WymDostawa SprDost { get; set; } = null!;

    public virtual WymKontrahent SprDst { get; set; } = null!;

    public virtual WymFirma SprFirma { get; set; } = null!;

    public virtual WymFormyPlatnosci SprFormPlat { get; set; } = null!;

    public virtual WymFormyPlatnosci SprFormPlatSpi { get; set; } = null!;

    public virtual WymGeografium SprGeo { get; set; } = null!;

    public virtual WymJednostka SprJmPodst { get; set; } = null!;

    public virtual WymJednostka SprJmp { get; set; } = null!;

    public virtual WymKategorieFinansowe SprKatFin { get; set; } = null!;

    public virtual WymLimityKontrahentum SprKlkg { get; set; } = null!;

    public virtual WymKontrahent SprKnd { get; set; } = null!;

    public virtual WymStazKlientum SprKndStaz { get; set; } = null!;

    public virtual WymKontrahent SprKnt { get; set; } = null!;

    public virtual WymStazKlientum SprKntStaz { get; set; } = null!;

    public virtual WymLokalizacja SprLok { get; set; } = null!;

    public virtual WymMagazyn SprMag { get; set; } = null!;

    public virtual WymMiejsceSkladowanium SprMskl { get; set; } = null!;

    public virtual WymOperator SprOpe { get; set; } = null!;

    public virtual WymOperator SprOpem { get; set; } = null!;

    public virtual WymOperator SprOpew { get; set; } = null!;

    public virtual WymOperator SprOpez { get; set; } = null!;

    public virtual WymPracownik SprOpiekun { get; set; } = null!;

    public virtual WymPracownik SprOpiekunSpinacz { get; set; } = null!;

    public virtual WymPerspektywa SprPerspektywa { get; set; } = null!;

    public virtual WymKontrahent SprPlat { get; set; } = null!;

    public virtual WymDokumentNumer? SprPlatDokNumer { get; set; }

    public virtual WymPracownik SprPracownik { get; set; } = null!;

    public virtual WymPrecyzjaMiary SprPrmg { get; set; } = null!;

    public virtual WymProdukt SprProd { get; set; } = null!;

    public virtual WymStazKlientum SprProdStaz { get; set; } = null!;

    public virtual WymProduktPozycjeDok SprProduktPozycjeDok { get; set; } = null!;

    public virtual WymProjekt SprProjekt { get; set; } = null!;

    public virtual WymRejon SprRejon { get; set; } = null!;

    public virtual WymRodzajKosztuSprzedazy SprRks { get; set; } = null!;

    public virtual WymRodzajCeny SprRodzCen { get; set; } = null!;

    public virtual WymDokumentNumer SprSpiNumer { get; set; } = null!;

    public virtual WymStrukturaFirmy SprStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw SprStrPrw { get; set; } = null!;

    public virtual WymWalutum SprWaluta { get; set; } = null!;

    public virtual WymTerminWaznosci SprWaznosc { get; set; } = null!;

    public virtual WymZrodloDanych SprZrodg { get; set; } = null!;
}
