using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class SubscriptionsFreeForm
{
    public int SffSubscriptionId { get; set; }

    public string SffConnection { get; set; } = null!;

    public string SffScenarioParam { get; set; } = null!;

    public int SffId { get; set; }

    public virtual Subscription SffSubscription { get; set; } = null!;
}
