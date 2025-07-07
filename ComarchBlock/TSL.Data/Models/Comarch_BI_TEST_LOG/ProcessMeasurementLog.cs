using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class ProcessMeasurementLog
{
    public int PmlId { get; set; }

    public int PmlTrnid { get; set; }

    public string PmlProcessName { get; set; } = null!;

    public string PmlCounterCategory { get; set; } = null!;

    public string PmlCounterName { get; set; } = null!;

    public string? PmlInstance { get; set; }

    public DateTime? PmlStartDate { get; set; }

    public DateTime? PmlFinishDate { get; set; }

    public int PmlInterval { get; set; }

    public int? PmlPreCompressionSize { get; set; }

    public string? PmlCompression { get; set; }

    public virtual Transformation PmlTrn { get; set; } = null!;

    public virtual ICollection<SamplesLog> SamplesLogs { get; set; } = new List<SamplesLog>();
}
