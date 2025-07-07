using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevOlapCubeMeasuresGroupDimensionAttribute
{
    public string CmdaId { get; set; } = null!;

    public string? CmdaViewReferenceId { get; set; }

    public string? CmdaKeyColumnsTableReferenceId { get; set; }

    public string? CmdaKeyColumnsReferenceId { get; set; }

    public string? CmdaType { get; set; }

    public string? CmdaCubeDimensionAttributeReferenceId { get; set; }

    public string? CmdaCubeDimensionReferenceId { get; set; }

    public string? CmdaMeasureGroupReferenceId { get; set; }

    public string? CmdaCubeReferenceId { get; set; }

    public string? CdmaCubeDimensionAttributeReferenceId { get; set; }
}
