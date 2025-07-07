using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktMarszrutum
{
    /// <summary>
    /// Relation to dimension Oddzial
    /// </summary>
    public int PmrszOddzasobGid { get; set; }

    /// <summary>
    /// Relation to dimension JednostkaCzasu
    /// </summary>
    public int PmrszJczgid { get; set; }

    /// <summary>
    /// Relation to dimension Oddzial
    /// </summary>
    public int PmrszOddzpgid { get; set; }

    /// <summary>
    /// Relation to dimension Oddzial
    /// </summary>
    public int PmrszOddgniazdoGid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PrmszTzakonRzeczZasobuCzdgid { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int PmrszProjektGid { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int PmrszDokNumerGid { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int PmrszKntGid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int PmrszStrFrmGid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PrmszTzakonPlanCzynnosciCzdgid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PrmszTrozRzeczZasobuCzdgid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PrmszTzakonRzeczCzynnosciCzdgid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PrmszTzakonPlanZasobuCzdgid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PrmszTrozPlanZasobuCzdgid { get; set; }

    /// <summary>
    /// Relation to dimension Technologia
    /// </summary>
    public int PmrszTchgid { get; set; }

    /// <summary>
    /// Relation to dimension Produkt
    /// </summary>
    public int PmrszProdGid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PrmszTrozPlanCzynnosciCzdgid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PmrszTrozRzeczCzynnosciCzdgid { get; set; }

    /// <summary>
    /// Relation to dimension Zasob
    /// </summary>
    public int PmrszZasgid { get; set; }

    /// <summary>
    /// Relation to dimension Czynnosc
    /// </summary>
    public int PmrszCzngid { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int PmrszKntDocGid { get; set; }

    /// <summary>
    /// Relation to dimension Funkcje
    /// </summary>
    public int PmrszPfugid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PmrszDataZamknieciaDokGid { get; set; }

    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int PmrszAlokacjaGid { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int PmrszBudzetGid { get; set; }

    public int PmrszId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int PmrszZrodgid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int PmrszCzdgid { get; set; }

    public string PmrszOrgId { get; set; } = null!;

    public string PmrszDirtyOrgId { get; set; } = null!;

    public string? PmrszOpis { get; set; }

    public DateTime PmrszTsinsert { get; set; }

    public DateTime PmrszTsupdate { get; set; }

    public int PmrszUpdateSubTransformationId { get; set; }

    public int? PmrszUpdateTransformationId { get; set; }

    public int PmrszInsertSubTransformationId { get; set; }

    public int? PmrszInsertTransformationId { get; set; }

    public int? PmrszMczasRealizacjiRzeczywistyZasobu { get; set; }

    public int? PmrszMczasRealizacjiPlanowanyZasobu { get; set; }

    public int? PmrszMczasRozliczeniowyRzeczywistyZasobu { get; set; }

    public int? PmrszMczasRozliczeniowyPlanowanyZasobu { get; set; }

    public int? PmrszMczasRealizacjiRzeczywistyCzynnosci { get; set; }

    public int? PmrszMczasRealizacjiPlanowanyCzynnosci { get; set; }

    public int? PmrszMczasRozliczeniowyRzeczywistyCzynnosci { get; set; }

    public int? PmrszMczasRozliczeniowyPlanowanyCzynnosci { get; set; }

    public int? PmrszMwzorcowyCzas { get; set; }

    public int? PmrszTerminOd { get; set; }

    public int? PmrszTerminDo { get; set; }

    public int PmrszCzdaktywnosciDoId { get; set; }

    public int PmrszCzdaktywnosciOdId { get; set; }

    public virtual WymCzasDzien PmrszCzdg { get; set; } = null!;

    public virtual WymCzasDzien PmrszDataZamknieciaDokG { get; set; } = null!;

    public virtual WymCzasDzien PmrszTrozRzeczCzynnosciCzdg { get; set; } = null!;

    public virtual WymCzasDzien PrmszTrozPlanCzynnosciCzdg { get; set; } = null!;

    public virtual WymCzasDzien PrmszTrozPlanZasobuCzdg { get; set; } = null!;

    public virtual WymCzasDzien PrmszTrozRzeczZasobuCzdg { get; set; } = null!;

    public virtual WymCzasDzien PrmszTzakonPlanCzynnosciCzdg { get; set; } = null!;

    public virtual WymCzasDzien PrmszTzakonPlanZasobuCzdg { get; set; } = null!;

    public virtual WymCzasDzien PrmszTzakonRzeczCzynnosciCzdg { get; set; } = null!;

    public virtual WymCzasDzien PrmszTzakonRzeczZasobuCzdg { get; set; } = null!;
}
