using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class AttributesInfo
{
    public int AtriRowId { get; set; }

    public int AtriId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int AtriZrodgid { get; set; }

    public string AtriOrgId { get; set; } = null!;

    public string AtriDirtyOrgId { get; set; } = null!;

    public string AtriNazwa { get; set; } = null!;

    public string? AtriOpis { get; set; }

    public string? AtriParDirtyOrgId { get; set; }

    public string? AtriParCleanOrgId { get; set; }

    public int? AtriParGid { get; set; }

    public DateTime AtriTsinsert { get; set; }

    public DateTime AtriTsupdate { get; set; }

    public DateTime AtriTimeFrom { get; set; }

    public DateTime? AtriTimeTo { get; set; }

    public int AtriChecksumKimball1 { get; set; }

    public int AtriChecksumKimball2 { get; set; }

    public int AtriUpdateSubTransformationId { get; set; }

    public int? AtriUpdateTransformationId { get; set; }

    public int AtriInsertSubTransformationId { get; set; }

    public int? AtriInsertTransformationId { get; set; }

    public byte[] AtriRowVersion { get; set; } = null!;

    public string? AtriObjectType { get; set; }

    public string? AtriPhysicalTabelName { get; set; }

    public string? AtriName { get; set; }

    public string? AtriPhysicalColumnKeyId { get; set; }

    public string? AtriPhysicalColumnNameId { get; set; }

    public string? AtriNameOrgId { get; set; }

    public string? AtriPhysicalColumnOrgIdKeyId { get; set; }

    public string? AtriPhysicalColumnOrgIdNameId { get; set; }

    public string? AtriPhysicalColumnKeyIdType { get; set; }

    public string? AtriPhysicalColumnNameIdType { get; set; }

    public string? AtriPhysicalColumnOrgIdKeyIdType { get; set; }

    public string? AtriPhysicalColumnOrgIdNameIdType { get; set; }

    public int? AtriObjectId { get; set; }

    public string? AtriObjectKey { get; set; }

    public string? AtriAttributeIdname { get; set; }

    public virtual WymZrodloDanych AtriZrodg { get; set; } = null!;
}
