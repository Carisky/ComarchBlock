using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymObecnosc
{
    public int ObeRowId { get; set; }

    public int ObeId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int ObeZrodgid { get; set; }

    public string ObeOrgId { get; set; } = null!;

    public string ObeDirtyOrgId { get; set; } = null!;

    public string ObeNazwa { get; set; } = null!;

    public string? ObeOpis { get; set; }

    public string? ObeParDirtyOrgId { get; set; }

    public string? ObeParCleanOrgId { get; set; }

    public int? ObeParGid { get; set; }

    public DateTime ObeTsinsert { get; set; }

    public DateTime ObeTsupdate { get; set; }

    public DateTime ObeTimeFrom { get; set; }

    public DateTime? ObeTimeTo { get; set; }

    public int ObeChecksumKimball1 { get; set; }

    public int ObeChecksumKimball2 { get; set; }

    public int ObeUpdateSubTransformationId { get; set; }

    public int? ObeUpdateTransformationId { get; set; }

    public int ObeInsertSubTransformationId { get; set; }

    public int? ObeInsertTransformationId { get; set; }

    public byte[] ObeRowVersion { get; set; } = null!;

    /// <summary>
    /// Odbior nadgodzin
    /// </summary>
    public string? ObeOdbNadgodzin { get; set; }

    /// <summary>
    /// Godzina rozpoczecia obecnosci
    /// </summary>
    public string? ObeGodzinaWejscia { get; set; }

    /// <summary>
    /// Godzina zakonczenia obecnosci
    /// </summary>
    public string? ObeGodzinaWyjscia { get; set; }

    public string? ObeRodzaj { get; set; }

    public virtual WymZrodloDanych ObeZrodg { get; set; } = null!;
}
