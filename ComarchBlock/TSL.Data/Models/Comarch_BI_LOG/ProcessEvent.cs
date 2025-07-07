using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class ProcessEvent
{
    public long PevtProcid { get; set; }

    public int? PevtSubTransformationId { get; set; }

    public int? PevtLevel { get; set; }

    public string PevtLoggerName { get; set; } = null!;

    public string PevtMessage { get; set; } = null!;

    public string? PevtException { get; set; }

    public bool PevtIsTask { get; set; }

    public DateTime PevtTsinsert { get; set; }

    public byte[] PevtRowVersion { get; set; } = null!;

    public DateTime PevtExecutionStart { get; set; }

    public DateTime? PevtExecutionEnd { get; set; }

    public int? PevtNodeDepth { get; set; }

    public int? PevtTableLinkId { get; set; }

    public int? PevtParent { get; set; }

    public bool PevtIsPackage { get; set; }

    public string PevtContext { get; set; } = null!;

    public long PevtId { get; set; }

    public virtual ICollection<EtlImportResult> EtlImportResults { get; set; } = new List<EtlImportResult>();

    public virtual Level? PevtLevelNavigation { get; set; }

    public virtual Process PevtProc { get; set; } = null!;
}
