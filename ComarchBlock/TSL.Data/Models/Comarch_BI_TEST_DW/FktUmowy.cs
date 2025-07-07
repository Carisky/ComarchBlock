using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktUmowy
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int UmyId { get; set; }

    public int UmyCzdid { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int UmyZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string UmyOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string UmyDirtyOrgId { get; set; } = null!;

    public string? UmyOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime UmyTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime UmyTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int UmyUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? UmyUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int UmyInsertSubTransformationId { get; set; }

    public int? UmyInsertTransformationId { get; set; }

    public int UmySvatid { get; set; }

    public int UmyUmeid { get; set; }

    public int UmyUmnid { get; set; }

    public int UmyDataRozId { get; set; }

    public int UmyOpiekunId { get; set; }

    public int UmyWalutaId { get; set; }

    public int UmyDataZawId { get; set; }

    public int UmyDataPotId { get; set; }

    public int UmyDataZakId { get; set; }

    public int UmyOpepid { get; set; }

    public int UmyKntId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int UmyBudzetId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int UmyAlokacjaId { get; set; }

    public int UmyOpewid { get; set; }

    public int UmyStrFrmId { get; set; }

    public int UmyKndId { get; set; }

    public int UmyAdrKndId { get; set; }

    public int UmyProjektId { get; set; }

    public decimal? UmyMwartoscBruto { get; set; }

    public decimal? UmyMwartoscNetto { get; set; }

    public decimal? UmyMwartoscBrutoFin { get; set; }

    public decimal? UmyMwartoscNettoFin { get; set; }

    public decimal? UmyMwartoscBrutoRuch { get; set; }

    public decimal? UmyMwartoscNettoRuch { get; set; }

    public decimal? UmyMczasUmowyPlan { get; set; }

    public decimal? UmyMczasDoKonPlan { get; set; }

    public decimal? UmyMczasObowiPlan { get; set; }

    public decimal? UmyMczasUmowyRzec { get; set; }

    public decimal? UmyMczasDoKonRzec { get; set; }

    public decimal? UmyMczasObowiRzec { get; set; }

    public decimal? UmyMwartoscBrutoWal { get; set; }

    public decimal? UmyMwartoscNettoWal { get; set; }

    public decimal? UmyMwartoscBrutoRuchWal { get; set; }

    public decimal? UmyMwartoscNettoRuchWal { get; set; }

    public int UmyObzid { get; set; }

    public int UmyWygId { get; set; }

    public int UmyUmnpid { get; set; }

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public string UmyOrgAtrId { get; set; } = null!;

    public string? UmyOrgAtrNagId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? UmyStrPrwId { get; set; }

    /// <summary>
    /// Relation to dimension Cechy
    /// </summary>
    public int UmyCechaGid { get; set; }

    /// <summary>
    /// Relation to dimension FormyPlatnosci
    /// </summary>
    public int UmyFormPlatGid { get; set; }

    /// <summary>
    /// Relation to dimension Produkt
    /// </summary>
    public int UmyProdGid { get; set; }

    /// <summary>
    /// Relation to dimension Jednostka
    /// </summary>
    public int UmyJmId { get; set; }

    /// <summary>
    /// Relation to dimension Jednostka
    /// </summary>
    public int UmyJmPid { get; set; }

    public string? UmyFlagaNb { get; set; }

    /// <summary>
    /// Ilość na elemencie towarowym
    /// </summary>
    public decimal? UmyMilosc { get; set; }

    /// <summary>
    /// Ilość na elemencie towarowym w jednostce pomocniczej
    /// </summary>
    public decimal? UmyMiloscJmP { get; set; }

    /// <summary>
    /// Wartość brutto elementu
    /// </summary>
    public decimal? UmyMwartoscBruttoElem { get; set; }

    /// <summary>
    /// Wartość netto elementu
    /// </summary>
    public decimal? UmyMwartoscNettoElem { get; set; }

    /// <summary>
    /// Wartość netto elementu w PLN
    /// </summary>
    public decimal? UmyMwartoscPlnelem { get; set; }

    public string? UmyOrgAtrEleId { get; set; }

    public virtual WymAdre UmyAdrKnd { get; set; } = null!;

    public virtual WymAlokacja UmyAlokacja { get; set; } = null!;

    public virtual WymBudzet UmyBudzet { get; set; } = null!;

    public virtual WymCechy UmyCechaG { get; set; } = null!;

    public virtual WymCzasDzien UmyCzd { get; set; } = null!;

    public virtual WymCzasDzien UmyDataPot { get; set; } = null!;

    public virtual WymCzasDzien UmyDataRoz { get; set; } = null!;

    public virtual WymCzasDzien UmyDataZak { get; set; } = null!;

    public virtual WymCzasDzien UmyDataZaw { get; set; } = null!;

    public virtual WymFormyPlatnosci UmyFormPlatG { get; set; } = null!;

    public virtual WymJednostka UmyJm { get; set; } = null!;

    public virtual WymJednostka UmyJmP { get; set; } = null!;

    public virtual WymKontrahent UmyKnd { get; set; } = null!;

    public virtual WymKontrahent UmyKnt { get; set; } = null!;

    public virtual WymObowiazywanie UmyObz { get; set; } = null!;

    public virtual WymOperator UmyOpep { get; set; } = null!;

    public virtual WymOperator UmyOpew { get; set; } = null!;

    public virtual WymPracownik UmyOpiekun { get; set; } = null!;

    public virtual WymProdukt UmyProdG { get; set; } = null!;

    public virtual WymProjekt UmyProjekt { get; set; } = null!;

    public virtual WymStrukturaFirmy UmyStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? UmyStrPrw { get; set; }

    public virtual WymStawkiVat UmySvat { get; set; } = null!;

    public virtual WymUmowaElement UmyUme { get; set; } = null!;

    public virtual WymUmowa UmyUmn { get; set; } = null!;

    public virtual WymUmowa UmyUmnp { get; set; } = null!;

    public virtual WymWalutum UmyWaluta { get; set; } = null!;

    public virtual WymWygasanie UmyWyg { get; set; } = null!;

    public virtual WymZrodloDanych UmyZrodg { get; set; } = null!;
}
