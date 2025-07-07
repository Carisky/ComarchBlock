using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class SubscriptionsDescription
{
    public int SdeSubscriptionId { get; set; }

    public string? SdeDescription { get; set; }

    public int SdeTextPosition { get; set; }

    public bool SdeIsSendReportDescription { get; set; }

    public bool SdeIsSendParameters { get; set; }

    public bool SdeIsSendConditionInfo { get; set; }

    public virtual Subscription SdeSubscription { get; set; } = null!;
}
