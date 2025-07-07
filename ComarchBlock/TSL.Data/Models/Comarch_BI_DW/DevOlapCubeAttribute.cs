using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DevOlapCubeAttribute
{
    public string CatrId { get; set; } = null!;

    public string? CatrAggregationUsage { get; set; }

    public bool? CatrIsVisible { get; set; }

    public bool? CatrIsEnable { get; set; }

    public string? CatrDimensionAttributeReferenceId { get; set; }

    public string? CatrCubeReferenceId { get; set; }

    public string? CatrOlapCubeDimensionReferenceId { get; set; }
}
