using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class Process
{
    public int? ProcTrnid { get; set; }

    public string ProcName { get; set; } = null!;

    public DateTime ProcExecutionStart { get; set; }

    public DateTime? ProcExecutionEnd { get; set; }

    public string ProcTerminationStatus { get; set; } = null!;

    public string? ProcType { get; set; }

    public byte[] ProcRowVersion { get; set; } = null!;

    public long ProcId { get; set; }

    public virtual ICollection<FtpAnalizeResult> FtpAnalizeResults { get; set; } = new List<FtpAnalizeResult>();

    public virtual TerminationStatusType ProcTerminationStatusNavigation { get; set; } = null!;

    public virtual Transformation? ProcTrn { get; set; }

    public virtual ProcessType? ProcTypeNavigation { get; set; }

    public virtual ICollection<ProcessEvent> ProcessEvents { get; set; } = new List<ProcessEvent>();
}
