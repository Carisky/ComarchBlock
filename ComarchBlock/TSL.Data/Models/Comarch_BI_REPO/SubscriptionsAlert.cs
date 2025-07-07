using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class SubscriptionsAlert
{
    public int SalSubscriptionId { get; set; }

    public string SalMdxquery { get; set; } = null!;

    public string SalMdxwhereClause { get; set; } = null!;

    public int SalConditionType { get; set; }

    public decimal SalThreshold { get; set; }

    public string? SalComment { get; set; }

    public string SalConnectionString { get; set; } = null!;

    public string SalCubeName { get; set; } = null!;

    public bool SalIsCustomMdxquery { get; set; }

    public bool SalUseDefaultConnection { get; set; }

    public virtual Subscription SalSubscription { get; set; } = null!;
}
