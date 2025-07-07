using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class BudgetVersionScheme
{
    public int Id { get; set; }

    public int BudgetVersionId { get; set; }

    public string? Name { get; set; }

    public int RowVer { get; set; }

    public byte[]? Scheme { get; set; }

    public bool IsPrimaryScheme { get; set; }

    public int? CreatorId { get; set; }
}
