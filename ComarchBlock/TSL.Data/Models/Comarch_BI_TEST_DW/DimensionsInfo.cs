using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DimensionsInfo
{
    public int DimiRowId { get; set; }

    public int DimiId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int DimiZrodgid { get; set; }

    public string DimiOrgId { get; set; } = null!;

    public string DimiDirtyOrgId { get; set; } = null!;

    public string DimiName { get; set; } = null!;

    public string? DimiOpis { get; set; }

    public string? DimiParDirtyOrgId { get; set; }

    public string? DimiParCleanOrgId { get; set; }

    public int? DimiParGid { get; set; }

    public DateTime DimiTsinsert { get; set; }

    public DateTime DimiTsupdate { get; set; }

    public DateTime DimiTimeFrom { get; set; }

    public DateTime? DimiTimeTo { get; set; }

    public int DimiChecksumKimball1 { get; set; }

    public int DimiChecksumKimball2 { get; set; }

    public int DimiUpdateSubTransformationId { get; set; }

    public int? DimiUpdateTransformationId { get; set; }

    public int DimiInsertSubTransformationId { get; set; }

    public int? DimiInsertTransformationId { get; set; }

    public byte[] DimiRowVersion { get; set; } = null!;

    public string? DimiObjectType { get; set; }

    public string? DimiPhysicalTabelName { get; set; }

    public string? DimiPhysicalColumnKeyId { get; set; }

    public string? DimiPhysicalColumnNameId { get; set; }

    public string? DimiNameOrgId { get; set; }

    public string? DimiPhysicalColumnOrgIdKeyId { get; set; }

    public string? DimiPhysicalColumnOrgIdNameId { get; set; }

    public string? DimiPhysicalColumnKeyIdType { get; set; }

    public string? DimiPhysicalColumnNameIdType { get; set; }

    public string? DimiPhysicalColumnOrgIdKeyIdType { get; set; }

    public string? DimiPhysicalColumnOrgIdNameIdType { get; set; }

    public int? DimiObjectId { get; set; }

    public string? DimiObjectKey { get; set; }

    public string? DimiAttributeIdname { get; set; }

    public virtual WymZrodloDanych DimiZrodg { get; set; } = null!;
}
