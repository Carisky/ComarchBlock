using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class AddClassLevel
{
    public int ClLevelId { get; set; }

    public int ClLevelGid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int ClLevelSrcgid { get; set; }

    public string ClLevelCleanOrgId { get; set; } = null!;

    public string ClLevelDirtyOrgId { get; set; } = null!;

    public string ClLevelName { get; set; } = null!;

    public string? ClLevelDescription { get; set; }

    public string? ClLevelParDirtyOrgId { get; set; }

    public string? ClLevelParCleanOrgId { get; set; }

    public int? ClLevelParGid { get; set; }

    public DateTime ClLevelTsinsert { get; set; }

    public DateTime ClLevelTsupdate { get; set; }

    public DateTime ClLevelTimeFrom { get; set; }

    public DateTime? ClLevelTimeTo { get; set; }

    public int ClLevelChecksumKimball1 { get; set; }

    public int ClLevelChecksumKimball2 { get; set; }

    public int ClLevelUpdateSubTransformationId { get; set; }

    public int? ClLevelUpdateTransformationId { get; set; }

    public int ClLevelInsertSubTransformationId { get; set; }

    public int? ClLevelInsertTransformationId { get; set; }

    public byte[] ClLevelRowVersion { get; set; } = null!;

    public string? ClLevelClassification { get; set; }

    public short? ClLevelLevel { get; set; }

    public string? ClLevelOrgUnitOrgId { get; set; }

    public virtual WymZrodloDanych ClLevelSrcg { get; set; } = null!;
}
