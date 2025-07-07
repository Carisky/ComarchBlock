using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class BudgetMeasure
{
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=all-delete-orphan;
    /// </summary>
    public int BudgetId { get; set; }

    public int RowVer { get; set; }

    public string Name { get; set; } = null!;

    public int CubeId { get; set; }

    public string? FormatString { get; set; }

    public bool IsCalculatedMeasure { get; set; }

    public byte[]? Properties { get; set; }

    public virtual Budget Budget { get; set; } = null!;

    public virtual ICollection<BudgetEntry> BudgetEntries { get; set; } = new List<BudgetEntry>();

    public virtual ICollection<BudgetMeasureTranslation> BudgetMeasureTranslations { get; set; } = new List<BudgetMeasureTranslation>();

    public virtual Cube Cube { get; set; } = null!;

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
