using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevOlapAttributesRelationship
{
    public string DarlId { get; set; } = null!;

    public string? DarlName { get; set; }

    public string? DarlType { get; set; }

    public string? DarlCardinality { get; set; }

    public bool? DarlIsVisible { get; set; }

    public string? DarlParentAttributeReferenceId { get; set; }

    public string? DarlChildAttributeReferenceId { get; set; }

    public string? DarlDimensionReferenceId { get; set; }
}
