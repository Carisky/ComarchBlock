using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Member
{
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=all-delete-orphan;
    /// </summary>
    public int LevelId { get; set; }

    public string Name { get; set; } = null!;

    public int RowVer { get; set; }

    public int? Keyid { get; set; }

    public string? OrgId { get; set; }

    public string Caption { get; set; } = null!;

    public int? OtherMemberId { get; set; }

    public virtual ICollection<BudgetMember> BudgetMembers { get; set; } = new List<BudgetMember>();

    public virtual Level Level { get; set; } = null!;

    public virtual ICollection<TimeMember> TimeMembers { get; set; } = new List<TimeMember>();
}
