using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class AttachedDynamicObjectsInfo
{
    public int AdoiRowId { get; set; }

    public int AdoiId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int AdoiZrodgid { get; set; }

    public string AdoiOrgId { get; set; } = null!;

    public string AdoiDirtyOrgId { get; set; } = null!;

    public string AdoiName { get; set; } = null!;

    public string? AdoiOpis { get; set; }

    public string? AdoiParDirtyOrgId { get; set; }

    public string? AdoiParCleanOrgId { get; set; }

    public int? AdoiParGid { get; set; }

    public DateTime AdoiTsinsert { get; set; }

    public DateTime AdoiTsupdate { get; set; }

    public DateTime AdoiTimeFrom { get; set; }

    public DateTime? AdoiTimeTo { get; set; }

    public int AdoiChecksumKimball1 { get; set; }

    public int AdoiChecksumKimball2 { get; set; }

    public int AdoiUpdateSubTransformationId { get; set; }

    public int? AdoiUpdateTransformationId { get; set; }

    public int AdoiInsertSubTransformationId { get; set; }

    public int? AdoiInsertTransformationId { get; set; }

    public byte[] AdoiRowVersion { get; set; } = null!;

    public string? AdoiObjectType { get; set; }

    public string? AdoiColumnKeyId { get; set; }

    public string? AdoiColumnKeyType { get; set; }

    public string? AdoiCubeName { get; set; }

    public byte? AdoiIsVisible { get; set; }

    public byte? AdoiIsEnable { get; set; }

    public string? AdoiStatus { get; set; }

    public int? AdoiObjectId { get; set; }

    public string? AdoiObjectKey { get; set; }

    public string? AdoiPhysicalTableName { get; set; }

    public virtual WymZrodloDanych AdoiZrodg { get; set; } = null!;
}
