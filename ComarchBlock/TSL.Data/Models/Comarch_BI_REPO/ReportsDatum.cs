using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class ReportsDatum
{
    public int RdaReportId { get; set; }

    public int RdaDefinitionType { get; set; }

    public string? RdaTextDefinition { get; set; }

    public byte[]? RdaBinaryDefinition { get; set; }

    public virtual Report RdaReport { get; set; } = null!;
}
