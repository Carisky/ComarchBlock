using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevOlapCubeHierarchy
{
    public string ChieId { get; set; } = null!;

    public bool? ChieIsVisible { get; set; }

    public bool? ChieIsEnable { get; set; }

    public string? ChieDimensionHierarchyReferenceId { get; set; }

    public string? ChieCubeReferenceId { get; set; }

    public string? ChieOlapCubeDimensionReferenceId { get; set; }
}
