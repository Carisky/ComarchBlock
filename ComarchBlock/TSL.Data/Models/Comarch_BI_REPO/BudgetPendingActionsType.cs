using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class BudgetPendingActionsType
{
    public int Id { get; set; }

    public string ActionTypeName { get; set; } = null!;

    public string? ActionTypeDescription { get; set; }

    public virtual ICollection<BudgetPendingAction> BudgetPendingActions { get; set; } = new List<BudgetPendingAction>();
}
