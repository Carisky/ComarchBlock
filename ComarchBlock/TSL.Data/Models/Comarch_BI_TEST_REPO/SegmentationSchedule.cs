using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class SegmentationSchedule
{
    public int SesId { get; set; }

    public int SesProcessesPlanId { get; set; }

    public string SesSendTime { get; set; } = null!;

    public string? SesShortPeriodStartTime { get; set; }

    public int? SesDayId { get; set; }

    public int? SesMonthId { get; set; }

    public int? SesDayOfMonth { get; set; }

    public int? SesSendYear { get; set; }

    public virtual SegmentationProcessesPlan SesProcessesPlan { get; set; } = null!;
}
