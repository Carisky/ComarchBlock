using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class BudgetMember
{
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=none;
    /// </summary>
    public int? BudgetId { get; set; }

    public int? MemberId { get; set; }

    /// <summary>
    /// One2ManyCascade=none;
    /// </summary>
    public int? ParentMemberId { get; set; }

    public int RowVer { get; set; }

    public DateTime? LastDataWarehouseLoad { get; set; }

    public bool? Leaf { get; set; }

    public int? MockMemberKeyId { get; set; }

    public virtual Budget? Budget { get; set; }

    public virtual ICollection<BudgetColumnValue> BudgetColumnValues { get; set; } = new List<BudgetColumnValue>();

    public virtual ICollection<BudgetEntry> BudgetEntries { get; set; } = new List<BudgetEntry>();

    public virtual ICollection<BudgetMember> InverseParentMember { get; set; } = new List<BudgetMember>();

    public virtual Member? Member { get; set; }

    public virtual BudgetMember? ParentMember { get; set; }

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
