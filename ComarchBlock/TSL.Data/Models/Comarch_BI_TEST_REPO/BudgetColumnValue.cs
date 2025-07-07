using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class BudgetColumnValue
{
    public int Id { get; set; }

    public int ColumnId { get; set; }

    /// <summary>
    /// One2Many=false;
    /// </summary>
    public int BudgetMemberId { get; set; }

    public decimal? Value { get; set; }

    public int RowVer { get; set; }

    public virtual BudgetMember BudgetMember { get; set; } = null!;

    public virtual BudgetColumn Column { get; set; } = null!;
}
