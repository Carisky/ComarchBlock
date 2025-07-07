using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class BudgetPendingAction
{
    public int Id { get; set; }

    public int ActionTypeId { get; set; }

    public DateTime LastActionDate { get; set; }

    public int ObjectId { get; set; }

    public int? BudgetMemberId { get; set; }

    public string? BudgetMemberName { get; set; }

    public bool? ProcessOlapDatabase { get; set; }

    public virtual BudgetPendingActionsType ActionType { get; set; } = null!;
}
