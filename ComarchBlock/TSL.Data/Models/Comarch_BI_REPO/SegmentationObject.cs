using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class SegmentationObject
{
    public int SoNodeId { get; set; }

    public int SoType { get; set; }

    public string SoDefinition { get; set; } = null!;

    public string? SoRelatedIds { get; set; }

    public int? SoStatusCode { get; set; }

    public DateTime? SoLastActionOn { get; set; }

    public bool? SoIsUndone { get; set; }

    public string? SoDescription { get; set; }

    public virtual SegmentationNode SoNode { get; set; } = null!;
}
