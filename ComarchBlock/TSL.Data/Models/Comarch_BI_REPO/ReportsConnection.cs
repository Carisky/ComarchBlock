using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class ReportsConnection
{
    public int RcnConnectionId { get; set; }

    public int RcnReportId { get; set; }

    public virtual Connection RcnConnection { get; set; } = null!;

    public virtual Report RcnReport { get; set; } = null!;
}
