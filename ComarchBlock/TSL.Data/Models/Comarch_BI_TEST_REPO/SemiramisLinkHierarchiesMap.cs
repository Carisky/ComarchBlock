using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class SemiramisLinkHierarchiesMap
{
    public int SlmSemiramisLinkHierarchiesId { get; set; }

    public string SlmHierarchyOrgId { get; set; } = null!;

    public virtual SemiramisLinkHierarchy SlmSemiramisLinkHierarchies { get; set; } = null!;
}
