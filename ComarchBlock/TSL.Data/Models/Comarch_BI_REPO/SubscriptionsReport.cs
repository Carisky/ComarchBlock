using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class SubscriptionsReport
{
    public int SreId { get; set; }

    public int SreSubscriptionId { get; set; }

    public int SreReportId { get; set; }

    public int? SreFolderId { get; set; }

    public virtual Report SreReport { get; set; } = null!;

    public virtual Subscription SreSubscription { get; set; } = null!;
}
