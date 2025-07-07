using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktZamowieniaKlientum
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZakCleanOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZakDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long ZakId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZakInsertSubTransformationId { get; set; }

    public int ZakInsertTransformationId { get; set; }

    public string? ZakOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZakTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZakTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZakUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ZakUpdateTransformationId { get; set; }

    /// <summary>
    /// Identyfikator akwizytora. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZakAkwId { get; set; }

    /// <summary>
    /// Data wystawienia ostatniego dokumentu PM do zamówienia. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZakCzdfaktId { get; set; }

    /// <summary>
    /// Data wystawienia zamówienia. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZakCzdid { get; set; }

    /// <summary>
    /// Data planowanej realizacji zamówienia. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZakCzdplanId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu zamówienia. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int ZakDokNumerId { get; set; }

    /// <summary>
    /// Identyfikator formy płatności. Relacja do wymiaru WYM_FormyPlatnosci
    /// </summary>
    public int ZakFormPlatId { get; set; }

    /// <summary>
    /// Identyfikator jednostki podstawowej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int ZakJmId { get; set; }

    /// <summary>
    /// Identyfikator jednostki pomocniczej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int ZakJmPid { get; set; }

    /// <summary>
    /// Identyfikator odbiorcy (kontrahenta docelowego). Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZakKnDid { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta. Relacja do wymiaru WYM_Kontrahent.
    /// </summary>
    public int ZakKntId { get; set; }

    /// <summary>
    /// Identyfikator magazynu domyślnego. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int ZakMagId { get; set; }

    /// <summary>
    /// Identyfikator płatnika. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZakPlatId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int ZakProdId { get; set; }

    /// <summary>
    /// Identyfikator struktury firmy. Relacja do wymiaru WYM_StrukturaFirmy
    /// </summary>
    public int ZakStrFrmId { get; set; }

    /// <summary>
    /// Identyfikator waluty, w której wystawione jest zamówienie. Relacja do wymiaru WYM_Waluta
    /// </summary>
    public int ZakWalutaId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZakZrodgid { get; set; }

    /// <summary>
    /// Ilość towaru w jednostce podstawowej
    /// </summary>
    public decimal? ZakMilosc { get; set; }

    /// <summary>
    /// Ilość towaru w jednostce pomocniczej
    /// </summary>
    public decimal? ZakMiloscJmP { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? ZakModchylenieRealizacji { get; set; }

    /// <summary>
    /// Wartość pozycji po rabacie wyrażona w walucie dokumentu
    /// </summary>
    public decimal? ZakMwartosc { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? ZakMwartoscKoszt { get; set; }

    /// <summary>
    /// Wartość pozycji po rabacie wyrażona w walucie systemowej
    /// </summary>
    public decimal? ZakMwartoscPln { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? ZakMwartoscSpr { get; set; }

    /// <summary>
    /// Zakładana cena towaru wyrażona w walucie systemowej
    /// </summary>
    public decimal? ZakMzakladanaCenaZ { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? ZakMzakladanaMarzaZ { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? ZakOrgAtrId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? ZakOrgWymId { get; set; }

    /// <summary>
    /// Informacja, czy zamówienie jest wewnętrzne czy zewnętrzne. Relacja do wymiaru WYM_TypZamowienia
    /// </summary>
    public int? ZakTzamId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int ZakBudzetId { get; set; }

    /// <summary>
    /// Wartość KGO dla elementu wyrażona w walucie dokumentu
    /// </summary>
    public decimal? ZakMkgo { get; set; }

    /// <summary>
    /// Stawka VAT
    /// </summary>
    public decimal? ZakMvat { get; set; }

    /// <summary>
    /// Flaga informująca czy wartości na dokumencie są liczone od netto czy od brutto
    /// </summary>
    public string? ZakFlagaNb { get; set; }

    /// <summary>
    /// Identyfikator opiekuna. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int ZakOpiekunId { get; set; }

    /// <summary>
    /// Pozycja elementu na zamówieniu
    /// </summary>
    public int? ZakPozycjaId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int ZakRejonId { get; set; }

    /// <summary>
    /// Ilość dni od daty wystawienia do realizacji zamówienia pobrana z elementu zamówienia, wyrażona w formacie Clarion
    /// </summary>
    public decimal? ZakMczasRealizacji { get; set; }

    /// <summary>
    /// Informacja, czy został udzielony rabat
    /// </summary>
    public decimal ZakCzyRabat { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Geografia
    /// </summary>
    public int ZakGeoid { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int ZakCechyId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int ZakAlokacjaId { get; set; }

    /// <summary>
    /// Informacja czy produkt ma flagę &apos;Gratis&apos; lub &apos;Złom&apos;. Relacja do wymiaru WYM_ProduktPozycjeDok
    /// </summary>
    public int ZakProduktPozycjeDokId { get; set; }

    /// <summary>
    /// Identyfikator adresu kontrahenta docelowego (odbiorcy). Relacja do wymiaru WYM_Adres
    /// </summary>
    public int ZakAdrKndId { get; set; }

    /// <summary>
    /// Rzeczywisty czas realizacji zamówienia. Różnica pomiędzy datą wystawienia dokumentu magazynowego wydającego towar a datą zamówienia
    /// </summary>
    public decimal? ZakMczasRealizacjiRzeczywisty { get; set; }

    /// <summary>
    /// Identyfikator kategorii ABC\XYZ przypisanej towarowi. Relacja do wymiaru WYM_KategoriaABCXYZ
    /// </summary>
    public int ZakAbcid { get; set; }

    public string? ZakOrgAtrEleId { get; set; }

    public string? ZakOrgAtrNagId { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int ZakPrmgid { get; set; }

    public int? ZakTypKwoty { get; set; }

    public int? ZakKierunek { get; set; }

    public int? ZakWymTyp { get; set; }

    /// <summary>
    /// Relation to dimension Lokalizacja
    /// </summary>
    public int ZakLokGid { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int ZakProjektGid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? ZakStrPrwId { get; set; }

    /// <summary>
    /// Wartosc brutto dla MWartosc
    /// </summary>
    public decimal? ZakMwartoscBrutto { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZakOpemgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZakOpegid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZakOpezgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZakOpewgid { get; set; }

    public decimal? ZakMwartoscBruttoPln { get; set; }

    public decimal? ZakMwaga { get; set; }

    public decimal? ZakMdni { get; set; }

    public int ZakZamStanId { get; set; }

    public int ZakDokElemId { get; set; }

    public int? Atr0212Id { get; set; }

    public int? Atr0213Id { get; set; }

    public decimal? Atrm021394721Id { get; set; }

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

    public decimal? ZakMiloscZrealizowana { get; set; }

    public decimal? ZakMiloscZarezerwowana { get; set; }

    public int? Atr02101Id { get; set; }

    public virtual WymKategoriaAbcxyz ZakAbc { get; set; } = null!;

    public virtual WymAdre ZakAdrKnd { get; set; } = null!;

    public virtual WymKontrahent ZakAkw { get; set; } = null!;

    public virtual WymAlokacja ZakAlokacja { get; set; } = null!;

    public virtual WymBudzet ZakBudzet { get; set; } = null!;

    public virtual WymCechy ZakCechy { get; set; } = null!;

    public virtual WymCzasDzien ZakCzd { get; set; } = null!;

    public virtual WymCzasDzien ZakCzdfakt { get; set; } = null!;

    public virtual WymCzasDzien ZakCzdplan { get; set; } = null!;

    public virtual WymDokumentElement ZakDokElem { get; set; } = null!;

    public virtual WymDokumentNumer ZakDokNumer { get; set; } = null!;

    public virtual WymFormyPlatnosci ZakFormPlat { get; set; } = null!;

    public virtual WymGeografium ZakGeo { get; set; } = null!;

    public virtual WymJednostka ZakJm { get; set; } = null!;

    public virtual WymJednostka ZakJmP { get; set; } = null!;

    public virtual WymKontrahent ZakKnD { get; set; } = null!;

    public virtual WymKontrahent ZakKnt { get; set; } = null!;

    public virtual WymLokalizacja ZakLokG { get; set; } = null!;

    public virtual WymMagazyn ZakMag { get; set; } = null!;

    public virtual WymOperator ZakOpeg { get; set; } = null!;

    public virtual WymOperator ZakOpemg { get; set; } = null!;

    public virtual WymOperator ZakOpewg { get; set; } = null!;

    public virtual WymOperator ZakOpezg { get; set; } = null!;

    public virtual WymPracownik ZakOpiekun { get; set; } = null!;

    public virtual WymKontrahent ZakPlat { get; set; } = null!;

    public virtual WymPrecyzjaMiary ZakPrmg { get; set; } = null!;

    public virtual WymProdukt ZakProd { get; set; } = null!;

    public virtual WymProduktPozycjeDok ZakProduktPozycjeDok { get; set; } = null!;

    public virtual WymProjekt ZakProjektG { get; set; } = null!;

    public virtual WymRejon ZakRejon { get; set; } = null!;

    public virtual WymStrukturaFirmy ZakStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? ZakStrPrw { get; set; }

    public virtual WymTypZamowienium? ZakTzam { get; set; }

    public virtual WymWalutum ZakWaluta { get; set; } = null!;

    public virtual WymZamowieniaStan ZakZamStan { get; set; } = null!;

    public virtual WymZrodloDanych ZakZrodg { get; set; } = null!;
}
