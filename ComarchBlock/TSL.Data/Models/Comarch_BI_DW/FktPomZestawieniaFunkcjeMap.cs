using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktPomZestawieniaFunkcjeMap
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZfmCleanOrgId { get; set; }

    public string? ZfmDescription { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZfmDirtyOrgId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long ZfmId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZfmInsertSubTransformationId { get; set; }

    public int? ZfmInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZfmTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZfmTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZfmUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZfmUpdateTransformationId { get; set; }

    public int ZfmCzdgid { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZfmZrodgid { get; set; }

    public decimal ZfmMnoznik { get; set; }

    public int? ZfmTyp { get; set; }

    public string? ZfmWyrazenie { get; set; }

    public int? ZfmZnak { get; set; }

    public int ZfmZstId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZfmZstOrgId { get; set; } = null!;

    public virtual WymCzasDzien ZfmCzdg { get; set; } = null!;

    public virtual WymZrodloDanych ZfmZrodg { get; set; } = null!;
}
