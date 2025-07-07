using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class BudgetColumnMember
{
    public int Id { get; set; }

    public int ColumnId { get; set; }

    public string? MemberName { get; set; }

    public string? LevelName { get; set; }

    public string? HierarchyName { get; set; }

    public string? DimensionName { get; set; }

    public int Group { get; set; }

    public int RowVer { get; set; }

    public virtual BudgetColumn Column { get; set; } = null!;
}
