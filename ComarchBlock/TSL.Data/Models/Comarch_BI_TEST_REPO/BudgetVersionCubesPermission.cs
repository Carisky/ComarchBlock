using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class BudgetVersionCubesPermission
{
    public int Id { get; set; }

    public int ExcludedCubeId { get; set; }

    public int BudgetVersionId { get; set; }

    public bool Excluded { get; set; }

    public int UserId { get; set; }

    public virtual BudgetVersion BudgetVersion { get; set; } = null!;

    public virtual Cube ExcludedCube { get; set; } = null!;

    public virtual User1 User { get; set; } = null!;
}
