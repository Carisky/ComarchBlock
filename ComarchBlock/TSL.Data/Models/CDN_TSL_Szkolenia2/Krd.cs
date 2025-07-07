using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class Krd
{
    public int KrdKrdId { get; set; }

    public int? KrdKntId { get; set; }

    public DateTime? KrdDataOdczytuStatusu { get; set; }

    public int? KrdStatus { get; set; }

    public int? KrdMonitoring { get; set; }

    public long? KrdMonitoringConditionId { get; set; }

    public string? KrdRaportId { get; set; }

    public string? KrdRegulamin { get; set; }

    public virtual Kontrahenci? KrdKnt { get; set; }
}
