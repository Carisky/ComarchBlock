using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class AddClassNode
{
    public int ClNodeId { get; set; }

    public int ClNodeGid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int ClNodeSrcgid { get; set; }

    public string ClNodeOrgId { get; set; } = null!;

    public string ClNodeDirtyOrgId { get; set; } = null!;

    public string ClNodeName { get; set; } = null!;

    public string? ClNodeDescription { get; set; }

    public string? ClNodeParDirtyOrgId { get; set; }

    public string? ClNodeParCleanOrgId { get; set; }

    public int? ClNodeParGid { get; set; }

    public DateTime ClNodeTsinsert { get; set; }

    public DateTime ClNodeTsupdate { get; set; }

    public DateTime ClNodeTimeFrom { get; set; }

    public DateTime? ClNodeTimeTo { get; set; }

    public int ClNodeChecksumKimball1 { get; set; }

    public int ClNodeChecksumKimball2 { get; set; }

    public int ClNodeUpdateSubTransformationId { get; set; }

    public int? ClNodeUpdateTransformationId { get; set; }

    public int ClNodeInsertSubTransformationId { get; set; }

    public int? ClNodeInsertTransformationId { get; set; }

    public byte[] ClNodeRowVersion { get; set; } = null!;

    public string? ClNodeClassification { get; set; }

    public short? ClNodeLevel { get; set; }

    public string? ClNodeCode { get; set; }

    public string? ClNodeDimElOrgId { get; set; }

    public string? ClNodeParentOrgId { get; set; }

    public int? ClNodeDimElGid { get; set; }

    public int? ClNodeParentGid { get; set; }

    public string? ClNodeOrgUnitOrgId { get; set; }

    public string? ClNodeCodeOrganization { get; set; }

    public string? ClNodeCodeOrganizationVersioning { get; set; }

    public string? ClNodeDimElVersioning { get; set; }

    public virtual WymZrodloDanych ClNodeSrcg { get; set; } = null!;
}
