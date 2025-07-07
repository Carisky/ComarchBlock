using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class AddClassAssign
{
    public int ClAssignId { get; set; }

    public int ClAssignGid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int ClAssignSrcgid { get; set; }

    public string ClAssignOrgId { get; set; } = null!;

    public string ClAssignDirtyOrgId { get; set; } = null!;

    public string ClAssignName { get; set; } = null!;

    public string? ClAssignDescription { get; set; }

    public string? ClAssignParDirtyOrgId { get; set; }

    public string? ClAssignParCleanOrgId { get; set; }

    public int? ClAssignParGid { get; set; }

    public DateTime ClAssignTsinsert { get; set; }

    public DateTime ClAssignTsupdate { get; set; }

    public DateTime ClAssignTimeFrom { get; set; }

    public DateTime? ClAssignTimeTo { get; set; }

    public int ClAssignChecksumKimball1 { get; set; }

    public int ClAssignChecksumKimball2 { get; set; }

    public int ClAssignUpdateSubTransformationId { get; set; }

    public int? ClAssignUpdateTransformationId { get; set; }

    public int ClAssignInsertSubTransformationId { get; set; }

    public int? ClAssignInsertTransformationId { get; set; }

    public byte[] ClAssignRowVersion { get; set; } = null!;

    public string? ClAssignClassification { get; set; }

    public string? ClAssignOrgUnitOrgId { get; set; }

    public bool? ClAssignOrganizationDependent { get; set; }

    public virtual WymZrodloDanych ClAssignSrcg { get; set; } = null!;
}
