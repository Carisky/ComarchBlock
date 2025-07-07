using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktParametryEtl
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int PelId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PelZrodgid { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int PelCzdgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PelOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PelDirtyOrgId { get; set; } = null!;

    public string? PelOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PelUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PelUpdateSubTransformationId { get; set; }

    public int PelInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PelInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PelTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PelTsupdate { get; set; }

    /// <summary>
    /// Wartość współczynnika kredytowania
    /// </summary>
    public decimal? PelWspKredytowania { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? PelProcesowanieOlap { get; set; }

    public virtual WymCzasDzien PelCzdg { get; set; } = null!;
}
