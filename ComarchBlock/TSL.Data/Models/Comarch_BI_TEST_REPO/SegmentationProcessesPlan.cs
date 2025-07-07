using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class SegmentationProcessesPlan
{
    public int SppId { get; set; }

    public int SppProcessId { get; set; }

    public int SppSendTimePeriod { get; set; }

    public DateTime? SppStartDate { get; set; }

    public DateTime? SppEndDate { get; set; }

    public DateTime? SppLastSent { get; set; }

    public int? SppLastSendCode { get; set; }

    public bool SppActive { get; set; }

    public string? SppName { get; set; }

    public int SppCompanyId { get; set; }

    public virtual ICollection<SegmentationSchedule> SegmentationSchedules { get; set; } = new List<SegmentationSchedule>();
}
