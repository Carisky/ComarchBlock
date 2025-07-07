using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class SubscriptionsUser
{
    public int SusSubscriptionId { get; set; }

    public int? SusUserId { get; set; }

    public int? SusGroupId { get; set; }

    public int? SusExternalUserId { get; set; }

    public int? SusPhoneUserId { get; set; }

    public int SusId { get; set; }

    public virtual SubscriptionsExternalUser? SusExternalUser { get; set; }

    public virtual Group1? SusGroup { get; set; }

    public virtual SubscriptionsPhoneUser? SusPhoneUser { get; set; }

    public virtual Subscription SusSubscription { get; set; } = null!;

    public virtual User1? SusUser { get; set; }
}
