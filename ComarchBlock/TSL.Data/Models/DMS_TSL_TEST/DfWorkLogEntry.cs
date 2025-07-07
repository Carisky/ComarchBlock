using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkLogEntry
{
    public int LeId { get; set; }

    public DateTime? LeTimeStamp { get; set; }

    public string? LeMessage { get; set; }

    public string? LeLevel { get; set; }

    public string? LeLogger { get; set; }

    public byte LeType { get; set; }

    public int? LeDocumentId { get; set; }
}
