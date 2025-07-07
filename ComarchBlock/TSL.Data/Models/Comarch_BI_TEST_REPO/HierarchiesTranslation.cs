using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class HierarchiesTranslation
{
    public int HtlId { get; set; }

    public int HtlHierarchyId { get; set; }

    public string HtlLocaleId { get; set; } = null!;

    public string? HtlTranslation { get; set; }

    public virtual Hierarchy1 HtlHierarchy { get; set; } = null!;
}
