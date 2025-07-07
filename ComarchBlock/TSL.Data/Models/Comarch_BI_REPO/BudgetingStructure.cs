using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class BudgetingStructure
{
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=all-delete-orphan;
    /// </summary>
    public int BudgetId { get; set; }

    public int LevelId { get; set; }

    public int LevelOrder { get; set; }

    public int RowVer { get; set; }

    public virtual Budget Budget { get; set; } = null!;

    public virtual Level Level { get; set; } = null!;
}
