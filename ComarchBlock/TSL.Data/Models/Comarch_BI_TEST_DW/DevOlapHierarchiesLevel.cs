using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevOlapHierarchiesLevel
{
    public string OhleId { get; set; } = null!;

    public string? OhleOlapId { get; set; }

    public string? OhleName { get; set; }

    public string? OhleDescription { get; set; }

    public int? OhleLevel { get; set; }

    public string? OhleDimensionReferenceId { get; set; }

    public string? OhleHierarchyReferenceId { get; set; }

    public string? OhleSourceAttributeReferenceId { get; set; }

    public string? OhleTranslationId { get; set; }
}
