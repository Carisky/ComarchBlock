using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktZakupy
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZkpDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long ZkpId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZkpInsertSubTransformationId { get; set; }

    public int ZkpInsertTransformationId { get; set; }

    public string? ZkpOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZkpOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZkpTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZkpTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZkpUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ZkpUpdateTransformationId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int ZkpBudzetId { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int ZkpCechyId { get; set; }

    /// <summary>
    /// Identyfikator daty controllingowej. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZkpCzdid { get; set; }

    /// <summary>
    /// Data zaksięgowania dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZkpCzdKsiegowaniaId { get; set; }

    /// <summary>
    /// Data przyjęcia towaru. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZkpCzdPrzyjeciaId { get; set; }

    /// <summary>
    /// Termin płatności. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZkpCzdterminPlatId { get; set; }

    /// <summary>
    /// Data wływu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZkpCzdWplywuId { get; set; }

    /// <summary>
    /// Data wystawienia dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZkpCzdWystawieniaId { get; set; }

    /// <summary>
    /// Data zakupu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZkpCzdZakupuId { get; set; }

    /// <summary>
    /// Data controllingowa dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZkpDataDokumentuId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int ZkpDokNumerId { get; set; }

    /// <summary>
    /// Identyfiktor dostawcy. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZkpDstId { get; set; }

    /// <summary>
    /// Identyfikator firmy. Relacja do wymiaru WYM_Firma
    /// </summary>
    public int ZkpFirmaId { get; set; }

    /// <summary>
    /// Identyfikator formy płatności. Relacja do wymiaru WYM_FormyPlatnosci
    /// </summary>
    public int ZkpFormPlatId { get; set; }

    /// <summary>
    /// Idnetyfikator jednostki podstawowej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int ZkpJmId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta docelowego. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZkpKndId { get; set; }

    /// <summary>
    /// Identyfikator stażu kontrahenta docelowego. Relacja do wymiaru WYM_StazKlienta
    /// </summary>
    public int ZkpKndStazId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZkpKntId { get; set; }

    /// <summary>
    /// Identyfikator stażu kontrahenta. Relacja do wymiaru WYM_StazKlienta
    /// </summary>
    public int ZkpKntStazId { get; set; }

    /// <summary>
    /// Relacja do wymiaru analitycznego WYM_Lokalizacja
    /// </summary>
    public int ZkpLokId { get; set; }

    /// <summary>
    /// Identyfikator magazynu docelowego. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int ZkpMagId { get; set; }

    /// <summary>
    /// Identyfikator płatnika. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZkpPlatId { get; set; }

    /// <summary>
    /// Identyfikator opiekuna kontrahenta. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int ZkpPracownikId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int ZkpProdId { get; set; }

    /// <summary>
    /// Identyfikator stażu towawu. Relacja do wymiaru WYM_StazKlienta
    /// </summary>
    public int ZkpProdStazId { get; set; }

    /// <summary>
    /// Relacja do wymiaru analitycznego WYM_Projekt
    /// </summary>
    public int ZkpProjektId { get; set; }

    /// <summary>
    /// Identyfikator rodzaju zakupu. Relacja do wymiaru WYM_RodzajZakupu.
    /// </summary>
    public int ZkpRdzId { get; set; }

    /// <summary>
    /// Identyfikator spinacza dokumentu. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int ZkpSpiNumerId { get; set; }

    /// <summary>
    /// Identyfikator struktury firmy. Relacja do wymiaru analitycznego WYM_StrukturaFirmy
    /// </summary>
    public int ZkpStrFrmId { get; set; }

    /// <summary>
    /// Identyfikator waluty użytej na dokumencie. Relacja do wymiaru WYM_Waluta.
    /// </summary>
    public int ZkpWalutaId { get; set; }

    /// <summary>
    /// Różnica pomiędzy datą wystawienia dokumentu a domyślnym terminem płatności. Relacja do wymiaru WYM_Zapadalnosc
    /// </summary>
    public int ZkpZapId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZkpZrodgid { get; set; }

    /// <summary>
    /// Punktacja towaru.
    /// </summary>
    public decimal? ZkpMbonusyPunkty { get; set; }

    /// <summary>
    /// Ilość towaru pobrana z subelementu
    /// </summary>
    public decimal? ZkpMilosc { get; set; }

    /// <summary>
    /// Staż kontrahenta docelowego
    /// </summary>
    public decimal? ZkpMkndStaz { get; set; }

    /// <summary>
    /// Staż kontrahenta
    /// </summary>
    public decimal? ZkpMkntStaz { get; set; }

    /// <summary>
    /// Koszty transportu krajowego wyrażone w walucie systemowej
    /// </summary>
    public decimal? ZkpMkosztyTransportuPlnkraj { get; set; }

    /// <summary>
    /// Koszty transportu zagranicznego wyrażone w walucie systemowej
    /// </summary>
    public decimal? ZkpMkosztyTransportuPlnzagr { get; set; }

    /// <summary>
    /// Objętość towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? ZkpMobjetosc { get; set; }

    /// <summary>
    /// Staż produktu
    /// </summary>
    public decimal? ZkpMprodStaz { get; set; }

    /// <summary>
    /// Waga towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? ZkpMwaga { get; set; }

    /// <summary>
    /// Wartość towaru, wyrażona w walucie dokumentu
    /// </summary>
    public decimal? ZkpMwartosc { get; set; }

    /// <summary>
    /// Wartość towaru, wyrażona w walucie systemowej
    /// </summary>
    public decimal? ZkpMwartoscPln { get; set; }

    /// <summary>
    /// Wartość towaru przed rabatem, wyrażona w walucie systemowej
    /// </summary>
    public decimal? ZkpMwartoscPrzedRabatemPln { get; set; }

    /// <summary>
    /// Różnica pomiędzy datą wystawienia dokumentu a domyślnym terminem płatności
    /// </summary>
    public decimal? ZkpMzapadalnosc { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? ZkpKierunek { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? ZkpOrgAtrId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? ZkpOrgWymId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? ZkpPaczka { get; set; }

    /// <summary>
    /// Rodzaj zakupu
    /// </summary>
    public int? ZkpTypKwoty { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? ZkpWymObjGidLp { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? ZkpWymTyp { get; set; }

    /// <summary>
    /// Koszty dodatkowe na dokumencie
    /// </summary>
    public decimal? ZkpMkosztyDodatkowePln { get; set; }

    public decimal? ZkpMkgo { get; set; }

    public int? ZkpPozycjaId { get; set; }

    public int? ZkpSubPozycjaId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int ZkpRejonId { get; set; }

    public decimal? ZkpMiloscJpom { get; set; }

    /// <summary>
    /// Identyfikator dokumentu SAD. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int ZkpSadDokGid { get; set; }

    /// <summary>
    /// Koszty transportu krajowego wyrażone w walucie dokumentu
    /// </summary>
    public decimal? ZkpMkosztyTransportuKraj { get; set; }

    /// <summary>
    /// Koszty transportu zagranicznego wyrażone w walucie dokumentu
    /// </summary>
    public decimal? ZkpMkosztyTransportuZagr { get; set; }

    /// <summary>
    /// Identyfikator akwizytora. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZkpAkwId { get; set; }

    /// <summary>
    /// Informacja, czy został udzielony rabat
    /// </summary>
    public decimal ZkpCzyRabat { get; set; }

    /// <summary>
    /// Czas planowany realizacji zamowienia
    /// </summary>
    public int ZkpCzdplanId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu zamowienia. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int ZkpZamNumerId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Geografia
    /// </summary>
    public int ZkpGeoid { get; set; }

    /// <summary>
    /// Informacja, czy dokukment zakupowy jest powiązany z zamówieniem
    /// </summary>
    public decimal ZkpCzyZamowienie { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int ZkpAlokacjaId { get; set; }

    /// <summary>
    /// Informacja czy produkt ma flagę &apos;Gratis&apos; lub &apos;Złom&apos;. Relacja do wymiaru WYM_ProduktPozycjeDok
    /// </summary>
    public int ZkpProduktPozycjeDokId { get; set; }

    /// <summary>
    /// Identyfikator kategorii ABC\XYZ przypisanej towarowi. Relacja do wymiaru WYM_KategoriaABCXYZ
    /// </summary>
    public int ZkpAbcid { get; set; }

    public string? ZkpOrgAtrEleId { get; set; }

    public string? ZkpOrgAtrNagId { get; set; }

    public string? ZkpOrgAtrSubId { get; set; }

    /// <summary>
    /// Kolumna wskazuje czy dany wiersz pochodzi z dokumentu korekty lub nie (0/1).
    /// </summary>
    public bool? ZkpIsCorrection { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int ZkpPrmgid { get; set; }

    public decimal? ZakupyWartoscPrzedRabatemBdtcalc { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? ZkpStrPrwId { get; set; }

    public decimal? ZkpMwartoscBruttoPln { get; set; }

    public decimal? ZkpMwartoscBrutto { get; set; }

    /// <summary>
    /// Spinacz elementów - ilość w jednostce pomocniczej
    /// </summary>
    public decimal? ZkpMiloscJpomSpinacz { get; set; }

    /// <summary>
    /// Spinacz elementów - ilość
    /// </summary>
    public decimal? ZkpMiloscSpinacz { get; set; }

    /// <summary>
    /// Spinacz elementów - objętość
    /// </summary>
    public decimal? ZkpMobjetoscSpinacz { get; set; }

    /// <summary>
    /// Spinacz elementów - waga
    /// </summary>
    public decimal? ZkpMwagaSpinacz { get; set; }

    /// <summary>
    /// Spinacz elementów - wartość brutto w PLN
    /// </summary>
    public decimal? ZkpMwartoscBruttoPlnspinacz { get; set; }

    /// <summary>
    /// Spinacz elementów - wartość brutto
    /// </summary>
    public decimal? ZkpMwartoscBruttoSpinacz { get; set; }

    /// <summary>
    /// Spinacz elementów - Wartość PLN
    /// </summary>
    public decimal? ZkpMwartoscPlnspinacz { get; set; }

    /// <summary>
    /// Spinacz elementów - wartość przed rabatem w PLN
    /// </summary>
    public decimal? ZkpMwartoscPrzedRabatemPlnspinacz { get; set; }

    /// <summary>
    /// Spinacz elementów - wartość
    /// </summary>
    public decimal? ZkpMwartoscSpinacz { get; set; }

    /// <summary>
    /// Data rozliczenia. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZkpCzddataRozId { get; set; }

    public string? ZkpDataMod { get; set; }

    public int ZkpDokElemId { get; set; }

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

    public decimal? Atrm021315211Id { get; set; }

    public decimal? Atrm021333441Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public virtual WymKategoriaAbcxyz ZkpAbc { get; set; } = null!;

    public virtual WymKontrahent ZkpAkw { get; set; } = null!;

    public virtual WymAlokacja ZkpAlokacja { get; set; } = null!;

    public virtual WymBudzet ZkpBudzet { get; set; } = null!;

    public virtual WymCechy ZkpCechy { get; set; } = null!;

    public virtual WymCzasDzien ZkpCzd { get; set; } = null!;

    public virtual WymCzasDzien ZkpCzdKsiegowania { get; set; } = null!;

    public virtual WymCzasDzien ZkpCzdPrzyjecia { get; set; } = null!;

    public virtual WymCzasDzien ZkpCzdWplywu { get; set; } = null!;

    public virtual WymCzasDzien ZkpCzdWystawienia { get; set; } = null!;

    public virtual WymCzasDzien ZkpCzdZakupu { get; set; } = null!;

    public virtual WymCzasDzien ZkpCzddataRoz { get; set; } = null!;

    public virtual WymCzasDzien ZkpCzdplan { get; set; } = null!;

    public virtual WymCzasDzien ZkpCzdterminPlat { get; set; } = null!;

    public virtual WymCzasDzien ZkpDataDokumentu { get; set; } = null!;

    public virtual WymDokumentElement ZkpDokElem { get; set; } = null!;

    public virtual WymDokumentNumer ZkpDokNumer { get; set; } = null!;

    public virtual WymKontrahent ZkpDst { get; set; } = null!;

    public virtual WymFirma ZkpFirma { get; set; } = null!;

    public virtual WymFormyPlatnosci ZkpFormPlat { get; set; } = null!;

    public virtual WymGeografium ZkpGeo { get; set; } = null!;

    public virtual WymJednostka ZkpJm { get; set; } = null!;

    public virtual WymKontrahent ZkpKnd { get; set; } = null!;

    public virtual WymStazKlientum ZkpKndStaz { get; set; } = null!;

    public virtual WymKontrahent ZkpKnt { get; set; } = null!;

    public virtual WymStazKlientum ZkpKntStaz { get; set; } = null!;

    public virtual WymLokalizacja ZkpLok { get; set; } = null!;

    public virtual WymMagazyn ZkpMag { get; set; } = null!;

    public virtual WymKontrahent ZkpPlat { get; set; } = null!;

    public virtual WymPracownik ZkpPracownik { get; set; } = null!;

    public virtual WymPrecyzjaMiary ZkpPrmg { get; set; } = null!;

    public virtual WymProdukt ZkpProd { get; set; } = null!;

    public virtual WymStazKlientum ZkpProdStaz { get; set; } = null!;

    public virtual WymProduktPozycjeDok ZkpProduktPozycjeDok { get; set; } = null!;

    public virtual WymProjekt ZkpProjekt { get; set; } = null!;

    public virtual WymRodzajZakupu ZkpRdz { get; set; } = null!;

    public virtual WymRejon ZkpRejon { get; set; } = null!;

    public virtual WymDokumentNumer ZkpSadDokG { get; set; } = null!;

    public virtual WymDokumentNumer ZkpSpiNumer { get; set; } = null!;

    public virtual WymStrukturaFirmy ZkpStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? ZkpStrPrw { get; set; }

    public virtual WymWalutum ZkpWaluta { get; set; } = null!;

    public virtual WymDokumentNumer ZkpZamNumer { get; set; } = null!;

    public virtual WymZapadalnosc ZkpZap { get; set; } = null!;

    public virtual WymZrodloDanych ZkpZrodg { get; set; } = null!;
}
