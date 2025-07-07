using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class SubscriptionsFtpConnection
{
    public int SfcId { get; set; }

    public int SfcSubscriptionId { get; set; }

    public int SfcFtpConnectionId { get; set; }

    public virtual FtpConnection SfcFtpConnection { get; set; } = null!;

    public virtual Subscription SfcSubscription { get; set; } = null!;
}
