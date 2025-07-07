using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class HierarchiesLevelInfo
{
    public int AhliRowId { get; set; }

    public int AhliId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int AhliZrodgid { get; set; }

    public string AhliOrgId { get; set; } = null!;

    public string AhliDirtyOrgId { get; set; } = null!;

    public string AhliName { get; set; } = null!;

    public string? AhliOpis { get; set; }

    public string? AhliParDirtyOrgId { get; set; }

    public string? AhliParCleanOrgId { get; set; }

    public int? AhliParGid { get; set; }

    public DateTime AhliTsinsert { get; set; }

    public DateTime AhliTsupdate { get; set; }

    public DateTime AhliTimeFrom { get; set; }

    public DateTime? AhliTimeTo { get; set; }

    public int AhliChecksumKimball1 { get; set; }

    public int AhliChecksumKimball2 { get; set; }

    public int AhliUpdateSubTransformationId { get; set; }

    public int? AhliUpdateTransformationId { get; set; }

    public int AhliInsertSubTransformationId { get; set; }

    public int? AhliInsertTransformationId { get; set; }

    public byte[] AhliRowVersion { get; set; } = null!;

    public string? AhliObjectType { get; set; }

    public string? AhliPhysicalColumnKeyId { get; set; }

    public string? AhliPhysicalColumnNameId { get; set; }

    public string? AhliNameOrgId { get; set; }

    public string? AhliPhysicalColumnOrgIdKeyId { get; set; }

    public string? AhliPhysicalColumnOrgIdNameId { get; set; }

    public string? AhliPhysicalColumnKeyIdType { get; set; }

    public string? AhliPhysicalColumnNameIdType { get; set; }

    public string? AhliPhysicalColumnOrgIdKeyIdType { get; set; }

    public string? AhliPhysicalColumnOrgIdNameIdType { get; set; }

    public string? AhliHierarchyLevel { get; set; }

    public int? AhliObjectId { get; set; }

    public string? AhliObjectKey { get; set; }

    public string? AhliPhysicalTableName { get; set; }

    public string? AhliHierarchyObjectKey { get; set; }

    public virtual WymZrodloDanych AhliZrodg { get; set; } = null!;
}
