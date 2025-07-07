using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class EdWorkApprocess
{
    public int EdwId { get; set; }

    public int EdwApdid { get; set; }

    public int? EdwEdmid { get; set; }

    public DateTime? EdwCreateDate { get; set; }

    public int EdwOperatorId { get; set; }

    public byte EdwStatus { get; set; }

    public bool EdwArchival { get; set; }
}
