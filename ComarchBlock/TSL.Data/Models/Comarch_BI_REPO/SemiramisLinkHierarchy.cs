using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class SemiramisLinkHierarchy
{
    public int SemId { get; set; }

    public string SemCubeName { get; set; } = null!;

    public string SemHierarchyName { get; set; } = null!;

    public string? SemAppName { get; set; }

    public int? SemActionId { get; set; }

    public string? SemBeLinkType { get; set; }

    public bool SemIsSupport { get; set; }

    public virtual SemiramisAction? SemAction { get; set; }

    public virtual ICollection<SemiramisLinkHierarchiesMap> SemiramisLinkHierarchiesMaps { get; set; } = new List<SemiramisLinkHierarchiesMap>();
}
