using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymAnkietum
{
    public int AnkRowId { get; set; }

    public int AnkId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int AnkZrodgid { get; set; }

    public string AnkOrgId { get; set; } = null!;

    public string AnkDirtyOrgId { get; set; } = null!;

    public string? AnkNazwa { get; set; }

    public string? AnkOpis { get; set; }

    public string? AnkParDirtyOrgId { get; set; }

    public string? AnkParCleanOrgId { get; set; }

    public int? AnkParGid { get; set; }

    public DateTime AnkTsinsert { get; set; }

    public DateTime AnkTsupdate { get; set; }

    public DateTime AnkTimeFrom { get; set; }

    public DateTime? AnkTimeTo { get; set; }

    public int AnkChecksumKimball1 { get; set; }

    public int AnkChecksumKimball2 { get; set; }

    public int AnkUpdateSubTransformationId { get; set; }

    public int? AnkUpdateTransformationId { get; set; }

    public int AnkInsertSubTransformationId { get; set; }

    public int? AnkInsertTransformationId { get; set; }

    public byte[] AnkRowVersion { get; set; } = null!;

    public string? AnkAnonimowa { get; set; }

    public string? AnkRodzaj { get; set; }

    public virtual WymZrodloDanych AnkZrodg { get; set; } = null!;
}
