using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class MlError
{
    public int MleId { get; set; }

    public int MleApdid { get; set; }

    public DateTime? MleCreateDate { get; set; }

    public int MleOperatorId { get; set; }

    public string? MleMessage { get; set; }
}
