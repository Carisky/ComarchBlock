using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class AnalystInterfaceReportLayout
{
    public int AilId { get; set; }

    public int AilReportId { get; set; }

    public int AilUserId { get; set; }

    public int AilReportLocation { get; set; }

    public DateTime AilInserted { get; set; }

    public DateTime AilUpdated { get; set; }

    public int AilSelectedReportDataType { get; set; }

    public virtual Report AilReport { get; set; } = null!;

    public virtual User1 AilUser { get; set; } = null!;
}
