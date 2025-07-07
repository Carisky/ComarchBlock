using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevOlapCubeMeasuresGroupsPartition
{
    public string CmgpId { get; set; } = null!;

    public string? CmgpOlapId { get; set; }

    public string? CmgpName { get; set; }

    public string? CmgpDescription { get; set; }

    public string? CmgpType { get; set; }

    public string? CmgpStorageMode { get; set; }

    public string? CmgpTableReferenceId { get; set; }

    public string? CmgpViewReferenceId { get; set; }

    public string? CmgdMeasureGroupReferenceId { get; set; }

    public string? CmgdCubeReferenceId { get; set; }
}
