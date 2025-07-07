using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class FtpConnection
{
    public int FcId { get; set; }

    public string FcConnectionName { get; set; } = null!;

    public string FcLogin { get; set; } = null!;

    public string FcPassword { get; set; } = null!;

    public string FcAddress { get; set; } = null!;

    public bool FcIsPredefinedConnection { get; set; }

    public bool FcIsDefaultFtpConnection { get; set; }

    public virtual ICollection<SegmentationFtpConnection> SegmentationFtpConnections { get; set; } = new List<SegmentationFtpConnection>();

    public virtual ICollection<SubscriptionsFtpConnection> SubscriptionsFtpConnections { get; set; } = new List<SubscriptionsFtpConnection>();
}
