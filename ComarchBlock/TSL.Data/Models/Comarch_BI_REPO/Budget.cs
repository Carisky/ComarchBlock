using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Budget
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int RowVer { get; set; }

    public int CubeId { get; set; }

    public bool Invisible { get; set; }

    public virtual ICollection<BudgetMeasure> BudgetMeasures { get; set; } = new List<BudgetMeasure>();

    public virtual ICollection<BudgetMember> BudgetMembers { get; set; } = new List<BudgetMember>();

    public virtual ICollection<BudgetVersion> BudgetVersions { get; set; } = new List<BudgetVersion>();

    public virtual ICollection<BudgetingStructure> BudgetingStructures { get; set; } = new List<BudgetingStructure>();

    public virtual Cube Cube { get; set; } = null!;
}
