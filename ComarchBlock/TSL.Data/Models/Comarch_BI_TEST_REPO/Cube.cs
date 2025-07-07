using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class Cube
{
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=all-delete-orphan;
    /// </summary>
    public int OlapServerId { get; set; }

    public string Name { get; set; } = null!;

    public int RowVer { get; set; }

    public int? IsDatabaseCube { get; set; }

    public virtual ICollection<BudgetMeasure> BudgetMeasures { get; set; } = new List<BudgetMeasure>();

    public virtual ICollection<BudgetVersionCubesPermission> BudgetVersionCubesPermissions { get; set; } = new List<BudgetVersionCubesPermission>();

    public virtual ICollection<Budget> Budgets { get; set; } = new List<Budget>();

    public virtual ICollection<CubeTranslation> CubeTranslations { get; set; } = new List<CubeTranslation>();

    public virtual ICollection<Dimension> Dimensions { get; set; } = new List<Dimension>();

    public virtual OlapServer OlapServer { get; set; } = null!;
}
