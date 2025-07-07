using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class OcWorkApprocess
{
    public int OcwId { get; set; }

    public int OcwApdid { get; set; }

    public long? OcwDocumentId { get; set; }

    public string? OcwLocalFileName { get; set; }

    public DateTime? OcwCreateDate { get; set; }

    public int OcwOperatorId { get; set; }

    public byte OcwStatus { get; set; }

    public string? OcwMessage { get; set; }

    public bool OcwArchival { get; set; }
}
