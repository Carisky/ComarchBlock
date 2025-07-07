using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class HierarchiesInfo
{
    public int AthiRowId { get; set; }

    public int AthiId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int AthiZrodgid { get; set; }

    public string AthiOrgId { get; set; } = null!;

    public string AthiDirtyOrgId { get; set; } = null!;

    public string AthiName { get; set; } = null!;

    public string? AthiOpis { get; set; }

    public string? AthiParDirtyOrgId { get; set; }

    public string? AthiParCleanOrgId { get; set; }

    public int? AthiParGid { get; set; }

    public DateTime AthiTsinsert { get; set; }

    public DateTime AthiTsupdate { get; set; }

    public DateTime AthiTimeFrom { get; set; }

    public DateTime? AthiTimeTo { get; set; }

    public int AthiChecksumKimball1 { get; set; }

    public int AthiChecksumKimball2 { get; set; }

    public int AthiUpdateSubTransformationId { get; set; }

    public int? AthiUpdateTransformationId { get; set; }

    public int AthiInsertSubTransformationId { get; set; }

    public int? AthiInsertTransformationId { get; set; }

    public byte[] AthiRowVersion { get; set; } = null!;

    public string? AthiObjectType { get; set; }

    public byte? AthiIsDirty { get; set; }

    public int? AthiMaxLevel { get; set; }

    public int? AthiObjectId { get; set; }

    public string? AthiObjectKey { get; set; }

    public virtual WymZrodloDanych AthiZrodg { get; set; } = null!;
}
