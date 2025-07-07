using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class SlError
{
    public int SleId { get; set; }

    public int SleApdid { get; set; }

    public DateTime? SleCreateDate { get; set; }

    public int SleOperatorId { get; set; }

    public string? SleMessage { get; set; }
}
