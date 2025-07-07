using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class SegmentationFtpConnection
{
    public int SfcId { get; set; }

    public int SfcSegmentationId { get; set; }

    public int SfcFtpConnectionId { get; set; }

    public string SfcBlockId { get; set; } = null!;

    public virtual FtpConnection SfcFtpConnection { get; set; } = null!;

    public virtual SegmentationNode SfcSegmentation { get; set; } = null!;
}
