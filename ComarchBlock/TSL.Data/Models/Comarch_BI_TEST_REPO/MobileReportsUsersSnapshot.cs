using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class MobileReportsUsersSnapshot
{
    public int RusReportId { get; set; }

    public int RusUserId { get; set; }

    public int RusSnapshotId { get; set; }

    public virtual Report RusReport { get; set; } = null!;

    public virtual MobileReportsSnapshot RusSnapshot { get; set; } = null!;

    public virtual User1 RusUser { get; set; } = null!;
}
