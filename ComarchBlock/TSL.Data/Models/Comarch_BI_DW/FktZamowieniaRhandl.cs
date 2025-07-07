using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktZamowieniaRhandl
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZrhDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long ZrhId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZrhInsertSubTransformationId { get; set; }

    public int ZrhInsertTransformationId { get; set; }

    public string? ZrhOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZrhOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZrhTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZrhTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZrhUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ZrhUpdateTransformationId { get; set; }

    /// <summary>
    /// Identyfikator akwizytora. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZrhAkwId { get; set; }

    /// <summary>
    /// Data sprzedaży/zakupu realizującego zamówienie. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZrhCzdfaktId { get; set; }

    /// <summary>
    /// Data wystawienia zamówienia. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZrhCzdid { get; set; }

    /// <summary>
    /// Data planowanej realizacji zamówienia. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZrhCzdplanId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu handlowego realizującego zamówienie. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int ZrhDokNumerId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu zamówienia. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int ZrhDokNumerZamId { get; set; }

    /// <summary>
    /// Identyfikator formy płatności, Relacja do wymiaru WYM_FormyPlatnosci
    /// </summary>
    public int ZrhFormPlatId { get; set; }

    /// <summary>
    /// Identyfikator jednostki podstawowej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int ZrhJmId { get; set; }

    /// <summary>
    /// Identyfikator jednostki pomocniczej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int ZrhJmPid { get; set; }

    /// <summary>
    /// Identyfikator odbiorcy (kontrahenta docelowego). Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZrhKnDid { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta. Relacja do wymiaru WYM_Kontrahent.
    /// </summary>
    public int ZrhKntId { get; set; }

    /// <summary>
    /// Identyfikator magazynu domyślnego. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int ZrhMagId { get; set; }

    /// <summary>
    /// Identyfikator opiekuna. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int ZrhOpiekunId { get; set; }

    /// <summary>
    /// Identyfikator płatnika. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZrhPlatId { get; set; }

    /// <summary>
    /// Identyfikator operatora wystawiającego. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int ZrhPrcId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int ZrhProdId { get; set; }

    /// <summary>
    /// Identyfikator struktury firmy. Relacja do wymiaru WYM_StrukturaFirmy
    /// </summary>
    public int ZrhStrFrmId { get; set; }

    /// <summary>
    /// Identyfikator waluty, w której wystawione jest zamówienie. Relacja do wymiaru WYM_Waluta
    /// </summary>
    public int ZrhWalutaId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZrhZrodgid { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? ZrhMcena { get; set; }

    /// <summary>
    /// Ilość towaru zrealizowana dokumentem handlowym, wyrażona w jednostce podstawowej
    /// </summary>
    public decimal? ZrhMilosc { get; set; }

    /// <summary>
    /// Ilość towaru zrealizowana dokumentem handlowym, wyrażona w jednostce pomocniczej
    /// </summary>
    public decimal? ZrhMiloscJmP { get; set; }

    /// <summary>
    /// Wartość księgowa kosztu, pobrana z subelementu
    /// </summary>
    public decimal? ZrhMkoszt { get; set; }

    /// <summary>
    /// Marża na towarze
    /// </summary>
    public decimal? ZrhMmarza { get; set; }

    /// <summary>
    /// Różnica pomiędzy datą wystawienia dokumentu handlowego do danego zamówienia a przewidywaną datą realizacji zamówienia
    /// </summary>
    public decimal? ZrhModchylenieRealizacji { get; set; }

    /// <summary>
    /// Procent udzielonego rabatu
    /// </summary>
    public decimal? ZrhMrabatProcent { get; set; }

    /// <summary>
    /// Wartość rabatu w walucie systemowej
    /// </summary>
    public decimal? ZrhMrabatWartosc { get; set; }

    /// <summary>
    /// Wartość elementu. pobrana z dokumentu handlowego realizującego zamowienie, wyrażona w walucie systemowej
    /// </summary>
    public decimal? ZrhMwartosc { get; set; }

    /// <summary>
    /// Wartość elementu. pobrana z dokumentu handlowego realizującego zamowienie, wyrażona w walucie dokumentu
    /// </summary>
    public decimal? ZrhMwartoscPln { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? ZrhOrgAtrId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? ZrhOrgWymId { get; set; }

    /// <summary>
    /// Informacja, czy zamówienie jest wewnętrzne czy zewnętrzne. Relacja do wymiaru WYM_TypZamowienia
    /// </summary>
    public int? ZrhTzamId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int ZrhBudzetId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? ZrhRejonId { get; set; }

    /// <summary>
    /// Różnica w dniach między datą wystawienia  dokumentu handlowego a przewidywaną datą zrealizowania zamówienia.
    /// </summary>
    public decimal? ZrhMdni { get; set; }

    /// <summary>
    /// Różnica w dniach między datą wystawienia  dokumentu handlowego a przewidywaną datą zrealizowania zamówienia. Relacja do wymiaru WYM_ZamowieniaStan
    /// </summary>
    public int ZrhZamStanId { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int ZrhCechyId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int ZrhAlokacjaId { get; set; }

    /// <summary>
    /// Informacja czy produkt ma flagę &apos;Gratis&apos; lub &apos;Złom&apos;. Relacja do wymiaru WYM_ProduktPozycjeDok
    /// </summary>
    public int ZrhProduktPozycjeDokId { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int ZrhPrmgid { get; set; }

    public decimal? ZamKlientaRhMarzaBdtcalc { get; set; }

    public int? ZrhTypKwoty { get; set; }

    public int? ZrhKierunek { get; set; }

    public int? ZrhWymTyp { get; set; }

    /// <summary>
    /// Relation to dimension Lokalizacja
    /// </summary>
    public int ZrhLokGid { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int ZrhProjektGid { get; set; }

    /// <summary>
    /// Punkty za nagrody w programie lojalnościowym
    /// </summary>
    public decimal? ZrhMzaePunkty { get; set; }

    /// <summary>
    /// Czy pozycja jest nagrodą w programie lojalnościowym
    /// </summary>
    public int? ZrhZaeNagroda { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZrhOpewgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZrhOpemgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZrhOpegid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZrhOpezgid { get; set; }

    public decimal? ZrhMwaga { get; set; }

    public int ZrhDokElemId { get; set; }

    public int? Atr0212Id { get; set; }

    public int? Atr0213Id { get; set; }

    public int? Atr0237Id { get; set; }

    public int? Atr0238Id { get; set; }

    public int? Atr0239Id { get; set; }

    public int? Atr0240Id { get; set; }

    public int? Atr0241Id { get; set; }

    public int? Atr0248Id { get; set; }

    public int? Atr0242Id { get; set; }

    public int? Atr0267Id { get; set; }

    public int? Atr027Id { get; set; }

    public int? Atr028Id { get; set; }

    public int? Atr029Id { get; set; }

    public int? Atr02101Id { get; set; }

    public virtual WymKontrahent ZrhAkw { get; set; } = null!;

    public virtual WymAlokacja ZrhAlokacja { get; set; } = null!;

    public virtual WymBudzet ZrhBudzet { get; set; } = null!;

    public virtual WymCechy ZrhCechy { get; set; } = null!;

    public virtual WymCzasDzien ZrhCzd { get; set; } = null!;

    public virtual WymCzasDzien ZrhCzdfakt { get; set; } = null!;

    public virtual WymCzasDzien ZrhCzdplan { get; set; } = null!;

    public virtual WymDokumentElement ZrhDokElem { get; set; } = null!;

    public virtual WymDokumentNumer ZrhDokNumer { get; set; } = null!;

    public virtual WymDokumentNumer ZrhDokNumerZam { get; set; } = null!;

    public virtual WymFormyPlatnosci ZrhFormPlat { get; set; } = null!;

    public virtual WymJednostka ZrhJm { get; set; } = null!;

    public virtual WymJednostka ZrhJmP { get; set; } = null!;

    public virtual WymKontrahent ZrhKnD { get; set; } = null!;

    public virtual WymKontrahent ZrhKnt { get; set; } = null!;

    public virtual WymLokalizacja ZrhLokG { get; set; } = null!;

    public virtual WymMagazyn ZrhMag { get; set; } = null!;

    public virtual WymOperator ZrhOpeg { get; set; } = null!;

    public virtual WymOperator ZrhOpemg { get; set; } = null!;

    public virtual WymOperator ZrhOpewg { get; set; } = null!;

    public virtual WymOperator ZrhOpezg { get; set; } = null!;

    public virtual WymPracownik ZrhOpiekun { get; set; } = null!;

    public virtual WymKontrahent ZrhPlat { get; set; } = null!;

    public virtual WymPracownik ZrhPrc { get; set; } = null!;

    public virtual WymPrecyzjaMiary ZrhPrmg { get; set; } = null!;

    public virtual WymProdukt ZrhProd { get; set; } = null!;

    public virtual WymProduktPozycjeDok ZrhProduktPozycjeDok { get; set; } = null!;

    public virtual WymProjekt ZrhProjektG { get; set; } = null!;

    public virtual WymRejon? ZrhRejon { get; set; }

    public virtual WymStrukturaFirmy ZrhStrFrm { get; set; } = null!;

    public virtual WymTypZamowienium? ZrhTzam { get; set; }

    public virtual WymWalutum ZrhWaluta { get; set; } = null!;

    public virtual WymZamowieniaStan ZrhZamStan { get; set; } = null!;

    public virtual WymZrodloDanych ZrhZrodg { get; set; } = null!;
}
