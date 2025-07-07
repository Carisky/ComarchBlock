using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class RightsReportsGroup
{
    public int RrgReportId { get; set; }

    public int RrgGroupId { get; set; }

    public byte RrgAccessRight { get; set; }

    public virtual Group1 RrgGroup { get; set; } = null!;

    public virtual Report RrgReport { get; set; } = null!;
}
