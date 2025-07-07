using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class BudgetEntry
{
    public int Id { get; set; }

    public int BudgetVersionId { get; set; }

    public int BudgetMeasureId { get; set; }

    /// <summary>
    /// CollectionName=TimeMemberBudgetEntries;
    /// </summary>
    public int TimeMemberId { get; set; }

    public int BudgetMemberId { get; set; }

    public decimal? Value { get; set; }

    public int RowVer { get; set; }

    public string State { get; set; } = null!;

    public string? Formula { get; set; }

    public virtual BudgetMeasure BudgetMeasure { get; set; } = null!;

    public virtual BudgetMember BudgetMember { get; set; } = null!;

    public virtual BudgetVersion BudgetVersion { get; set; } = null!;

    public virtual TimeMember TimeMember { get; set; } = null!;
}
