using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfReport
{
    public int RptId { get; set; }

    public Guid RptGuid { get; set; }

    public string? RptName { get; set; }

    public byte[]? RptData { get; set; }

    public bool RptArchival { get; set; }

    public bool RptShowInReportList { get; set; }

    public bool RptType { get; set; }

    public byte RptSource { get; set; }

    public string? RptDescription { get; set; }
}
