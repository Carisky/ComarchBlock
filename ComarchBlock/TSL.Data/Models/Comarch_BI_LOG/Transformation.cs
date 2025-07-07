using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class Transformation
{
    public int? TrnSesid { get; set; }

    public string? TrnTrntid { get; set; }

    public DateTime TrnTsinsert { get; set; }

    public byte[] TrnRowVersion { get; set; } = null!;

    public string? TrnParametersSet { get; set; }

    public DateTime TrnExecutionStart { get; set; }

    public DateTime? TrnExecutionEnd { get; set; }

    public int TrnId { get; set; }

    public string TrnTerminationStatus { get; set; } = null!;

    public int? TrnTrnpid { get; set; }

    public virtual ICollection<FtpMatchingFile> FtpMatchingFiles { get; set; } = new List<FtpMatchingFile>();

    public virtual ICollection<ProcessMeasurementLog> ProcessMeasurementLogs { get; set; } = new List<ProcessMeasurementLog>();

    public virtual ICollection<Process> Processes { get; set; } = new List<Process>();

    public virtual Session? TrnSes { get; set; }

    public virtual TerminationStatusType TrnTerminationStatusNavigation { get; set; } = null!;

    public virtual TransformationType? TrnTrnt { get; set; }
}
