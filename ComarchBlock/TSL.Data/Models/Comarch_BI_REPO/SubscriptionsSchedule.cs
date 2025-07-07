using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class SubscriptionsSchedule
{
    public int SscId { get; set; }

    public int SscSubscriptionId { get; set; }

    public string SscSendTime { get; set; } = null!;

    public string? SscShortPeriodStartTime { get; set; }

    public int? SscDayId { get; set; }

    public int? SscMonthId { get; set; }

    public int? SscDayOfMonth { get; set; }

    public int? SscSendYear { get; set; }

    public virtual Subscription SscSubscription { get; set; } = null!;
}
