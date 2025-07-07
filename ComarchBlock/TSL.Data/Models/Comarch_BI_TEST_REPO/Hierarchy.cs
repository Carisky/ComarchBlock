using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class Hierarchy
{
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=all-delete-orphan;
    /// </summary>
    public int DimensionId { get; set; }

    public string Name { get; set; } = null!;

    public string HierarchyOrigin { get; set; } = null!;

    public int RowVer { get; set; }

    public virtual Dimension Dimension { get; set; } = null!;

    public virtual ICollection<HierarchyTranslation> HierarchyTranslations { get; set; } = new List<HierarchyTranslation>();

    public virtual ICollection<Level> Levels { get; set; } = new List<Level>();
}
