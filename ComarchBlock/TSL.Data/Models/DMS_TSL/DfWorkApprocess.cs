using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkApprocess
{
    public int ApwId { get; set; }

    public int ApwApdid { get; set; }

    public long ApwDocumentId1 { get; set; }

    public long? ApwDocumentId2 { get; set; }
}
