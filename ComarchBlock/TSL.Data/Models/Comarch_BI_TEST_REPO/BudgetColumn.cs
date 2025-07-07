using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class BudgetColumn
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public int BudgetVersionId { get; set; }

    public string? BudgetMeasureName { get; set; }

    /// <summary>
    /// One2Many=false;Many2OneCascade=none;
    /// </summary>
    public int UserId { get; set; }

    public int RowVer { get; set; }

    public int Precision { get; set; }

    public virtual ICollection<BudgetColumnMember> BudgetColumnMembers { get; set; } = new List<BudgetColumnMember>();

    public virtual ICollection<BudgetColumnValue> BudgetColumnValues { get; set; } = new List<BudgetColumnValue>();

    public virtual BudgetVersion BudgetVersion { get; set; } = null!;

    public virtual User1 User { get; set; } = null!;
}
