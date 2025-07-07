using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class BudgetMeasureTranslation
{
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=all-delete-orphan;
    /// </summary>
    public int BudgetMeasureId { get; set; }

    public int Language { get; set; }

    public string Caption { get; set; } = null!;

    public int RowVer { get; set; }

    public virtual BudgetMeasure BudgetMeasure { get; set; } = null!;
}
