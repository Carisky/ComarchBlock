using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktZamowieniaRmag
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZrmDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long ZrmId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZrmInsertSubTransformationId { get; set; }

    public int ZrmInsertTransformationId { get; set; }

    public string? ZrmOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZrmOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZrmTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZrmTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZrmUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ZrmUpdateTransformationId { get; set; }

    /// <summary>
    /// Identyfikator akwizytora. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZrmAkwId { get; set; }

    /// <summary>
    /// Data wystawienia dokumentu magazynowego realizującego zamówienie. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZrmCzdfaktId { get; set; }

    /// <summary>
    /// Data wystawienia zamówienia. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZrmCzdid { get; set; }

    /// <summary>
    /// Data planowanej realizacji zamówienia. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZrmCzdplanId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu magazynowego realizującego zamówienie. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int ZrmDokNumerId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu zamówienia. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int ZrmDokNumerZamId { get; set; }

    /// <summary>
    /// Identyfikator jednostki podstawowej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int ZrmJmId { get; set; }

    /// <summary>
    /// Identyfikator jednostki pomocniczej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int ZrmJmPid { get; set; }

    /// <summary>
    /// Identyfikator odbiorcy (kontrahenta docelowego). Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZrmKnDid { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta. Relacja do wymiaru WYM_Kontrahent.
    /// </summary>
    public int ZrmKntId { get; set; }

    /// <summary>
    /// Identyfikator magazynu domyślnego. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int ZrmMagId { get; set; }

    /// <summary>
    /// Identyfikator opiekuna. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int ZrmOpiekunId { get; set; }

    /// <summary>
    /// Identyfikator płatnika. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZrmPlatId { get; set; }

    /// <summary>
    /// Identyfikator operatora wystawiającego. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int ZrmPrcId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int ZrmProdId { get; set; }

    /// <summary>
    /// Identyfikator struktury firmy. Relacja do wymiaru WYM_StrukturaFirmy
    /// </summary>
    public int ZrmStrFrmId { get; set; }

    /// <summary>
    /// Identyfikator waluty, w której wystawione jest zamówienie. Relacja do wymiaru WYM_Waluta
    /// </summary>
    public int ZrmWalutaId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZrmZrodgid { get; set; }

    /// <summary>
    /// Ilość towaru w jednostce podstawowej, pobrana z zamówienia
    /// </summary>
    public decimal? ZrmMilosc { get; set; }

    /// <summary>
    /// Ilość towaru w jednostce pomocniczej, pobrana z zamówienia
    /// </summary>
    public decimal? ZrmMiloscJmP { get; set; }

    /// <summary>
    /// Ilość zrealizowana, wyrażona w jednostce podstawowej, pobrana z dokumentu magazynowego
    /// </summary>
    public decimal? ZrmMiloscRealizacji { get; set; }

    /// <summary>
    /// Ilość zrealizowana, wyrażona w jednostce pomocniczej, pobrana z dokumentu magazynowego
    /// </summary>
    public decimal? ZrmMiloscRealizacjiJmP { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? ZrmOrgAtrId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? ZrmOrgWymId { get; set; }

    /// <summary>
    /// Informacja, czy zamówienie jest wewnętrzne czy zewnętrzne. Relacja do wymiaru WYM_TypZamowienia
    /// </summary>
    public int? ZrmTzamId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int ZrmBudzetId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int ZrmRejonId { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int ZrmCechyId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int ZrmAlokacjaId { get; set; }

    /// <summary>
    /// Informacja czy produkt ma flagę &apos;Gratis&apos; lub &apos;Złom&apos;. Relacja do wymiaru WYM_ProduktPozycjeDok
    /// </summary>
    public int ZrmProduktPozycjeDokId { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int ZrmPrmgid { get; set; }

    public int? ZrmTypKwoty { get; set; }

    public int? ZrmKierunek { get; set; }

    public int? ZrmWymTyp { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int ZrmProjektGid { get; set; }

    /// <summary>
    /// Relation to dimension Lokalizacja
    /// </summary>
    public int ZrmLokGid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZrmOpemgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZrmOpewgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZrmOpegid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZrmOpezgid { get; set; }

    public decimal? ZrmMwaga { get; set; }

    public int ZrmDokElemId { get; set; }

    public int? Atr0212Id { get; set; }

    public int? Atr0237Id { get; set; }

    public int? Atr0238Id { get; set; }

    public int? Atr0239Id { get; set; }

    public int? Atr0240Id { get; set; }

    public int? Atr0241Id { get; set; }

    public int? Atr0248Id { get; set; }

    public int? Atr0213Id { get; set; }

    public virtual WymKontrahent ZrmAkw { get; set; } = null!;

    public virtual WymAlokacja ZrmAlokacja { get; set; } = null!;

    public virtual WymBudzet ZrmBudzet { get; set; } = null!;

    public virtual WymCechy ZrmCechy { get; set; } = null!;

    public virtual WymCzasDzien ZrmCzd { get; set; } = null!;

    public virtual WymCzasDzien ZrmCzdfakt { get; set; } = null!;

    public virtual WymCzasDzien ZrmCzdplan { get; set; } = null!;

    public virtual WymDokumentElement ZrmDokElem { get; set; } = null!;

    public virtual WymDokumentNumer ZrmDokNumer { get; set; } = null!;

    public virtual WymDokumentNumer ZrmDokNumerZam { get; set; } = null!;

    public virtual WymJednostka ZrmJm { get; set; } = null!;

    public virtual WymJednostka ZrmJmP { get; set; } = null!;

    public virtual WymKontrahent ZrmKnD { get; set; } = null!;

    public virtual WymKontrahent ZrmKnt { get; set; } = null!;

    public virtual WymLokalizacja ZrmLokG { get; set; } = null!;

    public virtual WymMagazyn ZrmMag { get; set; } = null!;

    public virtual WymOperator ZrmOpeg { get; set; } = null!;

    public virtual WymOperator ZrmOpemg { get; set; } = null!;

    public virtual WymOperator ZrmOpewg { get; set; } = null!;

    public virtual WymOperator ZrmOpezg { get; set; } = null!;

    public virtual WymPracownik ZrmOpiekun { get; set; } = null!;

    public virtual WymKontrahent ZrmPlat { get; set; } = null!;

    public virtual WymPracownik ZrmPrc { get; set; } = null!;

    public virtual WymPrecyzjaMiary ZrmPrmg { get; set; } = null!;

    public virtual WymProdukt ZrmProd { get; set; } = null!;

    public virtual WymProduktPozycjeDok ZrmProduktPozycjeDok { get; set; } = null!;

    public virtual WymProjekt ZrmProjektG { get; set; } = null!;

    public virtual WymRejon ZrmRejon { get; set; } = null!;

    public virtual WymStrukturaFirmy ZrmStrFrm { get; set; } = null!;

    public virtual WymTypZamowienium? ZrmTzam { get; set; }

    public virtual WymWalutum ZrmWaluta { get; set; } = null!;

    public virtual WymZrodloDanych ZrmZrodg { get; set; } = null!;
}
