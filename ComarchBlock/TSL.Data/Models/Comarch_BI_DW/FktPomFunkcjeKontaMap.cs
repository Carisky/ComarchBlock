using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktPomFunkcjeKontaMap
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? FkmCleanOrgId { get; set; }

    public string? FkmDescription { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? FkmDirtyOrgId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long FkmId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FkmInsertSubTransformationId { get; set; }

    public int? FkmInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime FkmTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime FkmTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FkmUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FkmUpdateTransformationId { get; set; }

    public int FkmCzdgid { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int FkmZrodgid { get; set; }

    public string? FkmAnalityka { get; set; }

    public string? FkmFunkcja { get; set; }

    public int FkmKontoId { get; set; }

    public string? FkmKontoNumer { get; set; }

    public int FkmOrgKontoId { get; set; }

    public string? FkmWyrazenie { get; set; }

    public virtual WymCzasDzien FkmCzdg { get; set; } = null!;

    public virtual WymZrodloDanych FkmZrodg { get; set; } = null!;
}
