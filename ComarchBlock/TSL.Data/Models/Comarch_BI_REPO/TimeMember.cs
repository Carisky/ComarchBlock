using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class TimeMember
{
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=all-delete-orphan;Many2OneCascade=none;
    /// </summary>
    public int? BudgetVersionId { get; set; }

    /// <summary>
    /// Many2OneCascade=none;
    /// </summary>
    public int MemberId { get; set; }

    public int RowVer { get; set; }

    public DateTime? LastDataWarehouseLoad { get; set; }

    public virtual ICollection<BudgetEntry> BudgetEntries { get; set; } = new List<BudgetEntry>();

    public virtual BudgetVersion? BudgetVersion { get; set; }

    public virtual Member Member { get; set; } = null!;
}
