using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkCustomContentDiagnosticLog
{
    public int CcdId { get; set; }

    public int CcdCctid { get; set; }

    public int? CcdCcsid { get; set; }

    public Guid? CcdEventGuid { get; set; }

    public int? CcdDcdid { get; set; }

    public int? CcdDshid { get; set; }

    public int? CcdDwdid { get; set; }

    public int? CcdDdsid { get; set; }

    public int? CcdDkoid { get; set; }

    public int? CcdDmlid { get; set; }

    public DateTime CcdStartTime { get; set; }

    public int CcdDuration { get; set; }

    public virtual DfWorkCustomContentDiagnosticSession? CcdCcs { get; set; }

    public virtual DfWorkCustomContentType CcdCct { get; set; } = null!;
}
