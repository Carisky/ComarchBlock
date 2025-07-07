using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class SubscriptionsParameter
{
    public int SprSubscriptionId { get; set; }

    public string SprQuery { get; set; } = null!;

    public int? SprType { get; set; }

    public string SprName { get; set; } = null!;

    public int SprId { get; set; }

    public virtual Subscription SprSubscription { get; set; } = null!;
}
