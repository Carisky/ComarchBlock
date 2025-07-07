using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FeaturesInfo
{
    public int FetiRowId { get; set; }

    public int FetiId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int FetiZrodgid { get; set; }

    public string FetiOrgId { get; set; } = null!;

    public string FetiDirtyOrgId { get; set; } = null!;

    public string FetiName { get; set; } = null!;

    public string? FetiOpis { get; set; }

    public string? FetiParDirtyOrgId { get; set; }

    public string? FetiParCleanOrgId { get; set; }

    public int? FetiParGid { get; set; }

    public DateTime FetiTsinsert { get; set; }

    public DateTime FetiTsupdate { get; set; }

    public DateTime FetiTimeFrom { get; set; }

    public DateTime? FetiTimeTo { get; set; }

    public int FetiChecksumKimball1 { get; set; }

    public int FetiChecksumKimball2 { get; set; }

    public int FetiUpdateSubTransformationId { get; set; }

    public int? FetiUpdateTransformationId { get; set; }

    public int FetiInsertSubTransformationId { get; set; }

    public int? FetiInsertTransformationId { get; set; }

    public byte[] FetiRowVersion { get; set; } = null!;

    public string? FetiObjectType { get; set; }

    public string? FetiPhysicalTabelName { get; set; }

    public string? FetiPhysicalColumnKeyId { get; set; }

    public string? FetiPhysicalColumnNameId { get; set; }

    public string? FetiNameOrgId { get; set; }

    public string? FetiPhysicalColumnOrgIdKeyId { get; set; }

    public string? FetiPhysicalColumnOrgIdNameId { get; set; }

    public string? FetiPhysicalColumnKeyIdType { get; set; }

    public string? FetiPhysicalColumnNameIdType { get; set; }

    public string? FetiPhysicalColumnOrgIdKeyIdType { get; set; }

    public string? FetiPhysicalColumnOrgIdNameIdType { get; set; }

    public int? FetiObjectId { get; set; }

    public string? FetiObjectKey { get; set; }

    public string? FetiAttributeIdname { get; set; }

    public virtual WymZrodloDanych FetiZrodg { get; set; } = null!;
}
