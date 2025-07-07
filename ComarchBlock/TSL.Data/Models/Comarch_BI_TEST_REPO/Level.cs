using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class Level
{
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=all-delete-orphan;
    /// </summary>
    public int HierarchyId { get; set; }

    public string Name { get; set; } = null!;

    public int RowVer { get; set; }

    public short LevelDepth { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<BudgetingStructure> BudgetingStructures { get; set; } = new List<BudgetingStructure>();

    public virtual Hierarchy Hierarchy { get; set; } = null!;

    public virtual ICollection<LevelTranslation> LevelTranslations { get; set; } = new List<LevelTranslation>();

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();
}
