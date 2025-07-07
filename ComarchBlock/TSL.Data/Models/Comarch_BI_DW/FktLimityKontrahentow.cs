using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktLimityKontrahentow
{
    public int? KnlKntId { get; set; }

    public int? KnlWalutaGid { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int KnlId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int KnlZrodgid { get; set; }

    public int KnlCzdgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KnlOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KnlDirtyOrgId { get; set; } = null!;

    public string? KnlOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int KnlUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KnlUpdateSubTransformationId { get; set; }

    public int KnlInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KnlInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KnlTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KnlTsupdate { get; set; }

    public decimal? KnlMlimitSystem { get; set; }

    public decimal? KnlMlimitPoTermSystem { get; set; }

    public decimal? KnlMlimitSystemWaluta { get; set; }

    public decimal? KnlMlimitPoTermSystemWaluta { get; set; }

    public decimal? KnlMlimitSystemCentrala { get; set; }

    public decimal? KnlMlimitPoTermSystemCentrala { get; set; }

    public decimal? KnlMlimitSystemCentralaWaluta { get; set; }

    public decimal? KnlMlimitPoTermSystemCentralaWaluta { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int KnlAlokacjaId { get; set; }

    public virtual WymCzasDzien KnlCzdg { get; set; } = null!;
}
