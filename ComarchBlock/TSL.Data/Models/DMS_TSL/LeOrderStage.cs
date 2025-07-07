using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class LeOrderStage
{
    public int LsId { get; set; }

    public int LsDshid { get; set; }

    public string LsNameSource { get; set; } = null!;

    public string LsNameSink { get; set; } = null!;

    public int LsPredictionValue { get; set; }

    public int LsDcdid { get; set; }

    public DateTime LsCreateDate { get; set; }
}
