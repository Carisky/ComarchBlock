using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevOlapCubeMeasuresGroupDimension
{
    public string CmgdId { get; set; } = null!;

    public string? CmgdManyToManyMeasureGroupReferenceId { get; set; }

    public string? CmgdType { get; set; }

    public string? CmgdCubeDimensionReferenceId { get; set; }

    public string? CmgdMeasureGroupReferenceId { get; set; }

    public string? CmgdCubeReferenceId { get; set; }
}
