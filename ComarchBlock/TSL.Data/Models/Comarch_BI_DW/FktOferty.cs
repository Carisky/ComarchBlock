using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

/// <summary>
/// Tabela zawiera dane dotyczące ofert zakupu i sprzedaży
/// </summary>
public partial class FktOferty
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long OfeId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int OfeZrodgid { get; set; }

    /// <summary>
    /// Data wystawienia oferty.  Relacja do wymiaru WYM_CzasDzien.
    /// </summary>
    public int OfeCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string OfeOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string OfeDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public string? OfeOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int OfeUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? OfeUpdateSubTransformationId { get; set; }

    public int OfeInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? OfeInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime OfeTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime OfeTsupdate { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta docelowego, dla którego wystawiono dokument. Relacja do wymiaru WYM_Kontrahent. 
    /// </summary>
    public int OfeKndId { get; set; }

    /// <summary>
    /// Identyfikator produktu, który jest elementem na dokumencie. Relacja do wymiaru WYM_Produkt.
    /// </summary>
    public int OfeProdId { get; set; }

    /// <summary>
    /// Identyfikator jednostki podstawowej towaru. Relacja do wymiaru WYM_Jednostka.
    /// </summary>
    public int OfeJmId { get; set; }

    /// <summary>
    /// Forma płatności dokumentu (gotówka, przelew, czek, kredyt, karta, inne). Relacja do wymiaru WYM_FormyPlatnosci.
    /// </summary>
    public int OfeFormPlatId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta głównego, dla którego wystawiono dokument. Relacja do wymiaru WYM_Kontrahent.
    /// </summary>
    public int OfeKntId { get; set; }

    /// <summary>
    /// Identyfikator akwizytora, który widnieje na zakładce Kontrahent na dokumencie oferty.
    /// </summary>
    public int OfeAkwId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta płatnika, dla którego wystawiono dokument. Relacja do wymiaru WYM_Kontrahent.
    /// </summary>
    public int OfePlatId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu oferty. Relacja do wymiaru WYM_DokumentNumer.
    /// </summary>
    public int OfeDokNumerId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int OfeBudzetId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu oferty, która jest źródłem dla dokumentu oferty. Relacja do wymiaru WYM_DokumentNumer.
    /// </summary>
    public int OfeDokNumerZrdId { get; set; }

    /// <summary>
    /// Identyfikator jednostki pomocniczej w jakiej wyrażona jest ilość towaru na pozycji. 
    /// </summary>
    public int OfeJmPid { get; set; }

    /// <summary>
    /// Identyfikator symbolu waluty. Relacja do wymiaru WYM_Waluta.
    /// </summary>
    public int OfeWalutaId { get; set; }

    /// <summary>
    /// Data waznosci oferty. Relacja do wymiaru WYM_CzasDzien.
    /// </summary>
    public int OfeCzdwazId { get; set; }

    /// <summary>
    /// Identyfikator magazynu domyślnego. Relacja do wymiaru WYM_Magazyn.
    /// </summary>
    public int OfeMagId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_StrukturaFirmy.
    /// </summary>
    public int OfeStrFrmId { get; set; }

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public string OfeOrgAtrId { get; set; } = null!;

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public string? OfeWymTyp { get; set; }

    /// <summary>
    /// Ilość elementów na pozycji w jednostce podstawowej z oferty głównej.
    /// </summary>
    public decimal? OfeMilosc { get; set; }

    /// <summary>
    /// Ilość elementów na pozycji w jednostce pomocniczej. (pobierana z wariantu oferty)
    /// </summary>
    public decimal? OfeMiloscJmp { get; set; }

    /// <summary>
    /// Wartość netto  elementów na pozycji w walucie systemowej z oferty głównej.
    /// </summary>
    public decimal? OfeMwartosc { get; set; }

    /// <summary>
    /// Wartość netto  elementów na pozycji w walucie dokumentu z oferty głównej.
    /// </summary>
    public decimal? OfeMwartoscPln { get; set; }

    /// <summary>
    /// Identyfikator projektu. Relacja do wymiaru WYM_Projekt.
    /// </summary>
    public int OfeProjektId { get; set; }

    /// <summary>
    /// Identyfikator opiekuna. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int OfeOpiekunId { get; set; }

    /// <summary>
    /// Cena jednostkowa towarów na ofercie
    /// </summary>
    public decimal? OfeMcena { get; set; }

    /// <summary>
    /// Wartość marży elementów na pozycji (tylko dla ofert sprzedaży – dla ofert zakupów NULL) 
    /// </summary>
    public decimal? OfeMmarza { get; set; }

    /// <summary>
    /// 1 – oferty sprzedaży, 2 – oferty zakupu
    /// </summary>
    public int? OfeObszar { get; set; }

    /// <summary>
    /// Data realizacji oferty. Relacja do wymiaru WYM_CzasDzien.
    /// </summary>
    public int OfeCzdrealId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? OfeRejonId { get; set; }

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public int? OfePozycjaId { get; set; }

    /// <summary>
    /// Zakładany czas realizacji oferty
    /// </summary>
    public decimal? OfeMczasRealizacji { get; set; }

    /// <summary>
    /// Informacja, czy został udzielony rabat
    /// </summary>
    public decimal? OfeCzyRabat { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int OfeCechyId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int OfeAlokacjaId { get; set; }

    /// <summary>
    /// Informacja czy produkt ma flagę &apos;Gratis&apos; lub &apos;Złom&apos;. Relacja do wymiaru WYM_ProduktPozycjeDok
    /// </summary>
    public int OfeProduktPozycjeDokId { get; set; }

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public string? OfeOrgAtrEleId { get; set; }

    public string? OfeOrgAtrNagId { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int OfePrmgid { get; set; }

    public decimal? OfertaSprzedazyWartoscPrzedRabatemBdtcalc { get; set; }

    public decimal? OfertaZakupuWartoscPrzedRabatemBdtcalc { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? OfeStrPrwId { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int OfeOpezgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int OfeOpemgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int OfeOpewgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int OfeOperatorId { get; set; }

    public decimal? OfeMwaga { get; set; }

    public int? Atr0212Id { get; set; }

    public int? Atr0213Id { get; set; }

    public decimal? Atrm021389601Id { get; set; }

    public int? Atr0237Id { get; set; }

    public int? Atr0238Id { get; set; }

    public int? Atr0239Id { get; set; }

    public int? Atr0240Id { get; set; }

    public int? Atr0241Id { get; set; }

    public int? Atr0248Id { get; set; }

    public int? Atr0242Id { get; set; }

    public int? Atr027Id { get; set; }

    public int? Atr028Id { get; set; }

    public int? Atr029Id { get; set; }

    public virtual WymKontrahent OfeAkw { get; set; } = null!;

    public virtual WymAlokacja OfeAlokacja { get; set; } = null!;

    public virtual WymBudzet OfeBudzet { get; set; } = null!;

    public virtual WymCechy OfeCechy { get; set; } = null!;

    public virtual WymCzasDzien OfeCzd { get; set; } = null!;

    public virtual WymCzasDzien OfeCzdreal { get; set; } = null!;

    public virtual WymCzasDzien OfeCzdwaz { get; set; } = null!;

    public virtual WymDokumentNumer OfeDokNumer { get; set; } = null!;

    public virtual WymDokumentNumer OfeDokNumerZrd { get; set; } = null!;

    public virtual WymFormyPlatnosci OfeFormPlat { get; set; } = null!;

    public virtual WymJednostka OfeJm { get; set; } = null!;

    public virtual WymJednostka OfeJmP { get; set; } = null!;

    public virtual WymKontrahent OfeKnd { get; set; } = null!;

    public virtual WymKontrahent OfeKnt { get; set; } = null!;

    public virtual WymMagazyn OfeMag { get; set; } = null!;

    public virtual WymOperator OfeOpemg { get; set; } = null!;

    public virtual WymOperator OfeOperator { get; set; } = null!;

    public virtual WymOperator OfeOpewg { get; set; } = null!;

    public virtual WymOperator OfeOpezg { get; set; } = null!;

    public virtual WymPracownik OfeOpiekun { get; set; } = null!;

    public virtual WymKontrahent OfePlat { get; set; } = null!;

    public virtual WymPrecyzjaMiary OfePrmg { get; set; } = null!;

    public virtual WymProdukt OfeProd { get; set; } = null!;

    public virtual WymProduktPozycjeDok OfeProduktPozycjeDok { get; set; } = null!;

    public virtual WymProjekt OfeProjekt { get; set; } = null!;

    public virtual WymRejon? OfeRejon { get; set; }

    public virtual WymStrukturaFirmy OfeStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? OfeStrPrw { get; set; }

    public virtual WymWalutum OfeWaluta { get; set; } = null!;

    public virtual WymZrodloDanych OfeZrodg { get; set; } = null!;
}
