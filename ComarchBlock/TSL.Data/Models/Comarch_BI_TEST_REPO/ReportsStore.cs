using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class ReportsStore
{
    public int RstId { get; set; }

    public int RstReportId { get; set; }

    public int RstUserId { get; set; }

    public DateTime RstRenderedOn { get; set; }

    public byte[] RstRenderedReport { get; set; } = null!;

    public int RstRenderingFormat { get; set; }

    public bool RstIsForMobile { get; set; }

    public int? RstFolderId { get; set; }

    public int? RstSubscriptionId { get; set; }

    public virtual Report RstReport { get; set; } = null!;

    public virtual Subscription? RstSubscription { get; set; }

    public virtual User1 RstUser { get; set; } = null!;
}
