using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class SPomPropagacjaAtrybutow
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string AtrpCleanOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string AtrpDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long AtrpId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AtrpInsertSubTransformationId { get; set; }

    public int AtrpInsertTransformationId { get; set; }

    public string? AtrpOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime AtrpTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime AtrpTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AtrpUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int AtrpUpdateTransformationId { get; set; }

    public int AtrpCzdgid { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int AtrpZrodgid { get; set; }

    public string? AtrpNazwa { get; set; }

    public virtual WymCzasDzien AtrpCzdg { get; set; } = null!;

    public virtual WymZrodloDanych AtrpZrodg { get; set; } = null!;
}
