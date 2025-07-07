using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Permission
{
    /// <summary>
    /// One2ManyCascade=all-delete-orphan;
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=all-delete-orphan; One2ManyInverse=true; Many2OneCascade=none;
    /// </summary>
    public int BudgetVersionId { get; set; }

    /// <summary>
    /// Many2OneCascade=none;
    /// </summary>
    public int? UserGroupId { get; set; }

    /// <summary>
    /// One2ManyInverse=true;Many2OneCascade = save-update;
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// One2ManyInverse=true;Many2OneCascade=none;
    /// </summary>
    public int BudgetMemberId { get; set; }

    public bool Accept { get; set; }

    public bool Edit { get; set; }

    public bool Read { get; set; }

    public int RowVer { get; set; }

    /// <summary>
    /// One2ManyInverse=true;Many2OneCascade=none;
    /// </summary>
    public int BudgetMeasureId { get; set; }

    public virtual BudgetMeasure BudgetMeasure { get; set; } = null!;

    public virtual BudgetMember BudgetMember { get; set; } = null!;

    public virtual BudgetVersion BudgetVersion { get; set; } = null!;

    public virtual User1? User { get; set; }

    public virtual Group1? UserGroup { get; set; }
}
