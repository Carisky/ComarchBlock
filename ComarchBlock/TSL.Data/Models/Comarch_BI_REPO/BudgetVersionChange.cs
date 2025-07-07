using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class BudgetVersionChange
{
    public int Id { get; set; }

    public int BudgetVersionId { get; set; }

    /// <summary>
    /// One2Many=false;
    /// </summary>
    public int UserId { get; set; }

    public DateTime? Date { get; set; }

    public int RowVer { get; set; }

    public string State { get; set; } = null!;

    public int? LastLoadTransId { get; set; }

    public string? LastLoadDwScenarioName { get; set; }

    public virtual BudgetVersion BudgetVersion { get; set; } = null!;

    public virtual User1 User { get; set; } = null!;
}
