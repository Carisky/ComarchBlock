using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class SubscriptionsScenario
{
    public int SscSubscriptionId { get; set; }

    public string SscName { get; set; } = null!;

    public string SscQuery { get; set; } = null!;

    public int SscId { get; set; }

    public virtual Subscription SscSubscription { get; set; } = null!;
}
