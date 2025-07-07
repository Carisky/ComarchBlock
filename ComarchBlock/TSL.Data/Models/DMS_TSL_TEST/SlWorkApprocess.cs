using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class SlWorkApprocess
{
    public int SlwId { get; set; }

    public int SlwApdid { get; set; }

    public long? SlwDocumentId { get; set; }

    public long? SlwOcrOriginId { get; set; }

    public string? SlwLocalFileName { get; set; }

    public DateTime? SlwCreateDate { get; set; }

    public int SlwOperatorId { get; set; }

    public byte SlwStatus { get; set; }

    public string? SlwMessage { get; set; }

    public bool SlwArchival { get; set; }
}
