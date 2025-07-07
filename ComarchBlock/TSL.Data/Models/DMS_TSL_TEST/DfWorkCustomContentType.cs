using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkCustomContentType
{
    public int CctId { get; set; }

    public string? CctName { get; set; }

    public virtual ICollection<DfWorkCustomContentDiagnosticLog> DfWorkCustomContentDiagnosticLogs { get; set; } = new List<DfWorkCustomContentDiagnosticLog>();
}
