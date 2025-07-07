using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkCustomContentDiagnosticSession
{
    public int CcsId { get; set; }

    public bool? CcsIsActive { get; set; }

    public DateTime CcsStartTime { get; set; }

    public DateTime? CcsEndTime { get; set; }

    public string? CcsName { get; set; }

    public virtual ICollection<DfWorkCustomContentDiagnosticLog> DfWorkCustomContentDiagnosticLogs { get; set; } = new List<DfWorkCustomContentDiagnosticLog>();
}
