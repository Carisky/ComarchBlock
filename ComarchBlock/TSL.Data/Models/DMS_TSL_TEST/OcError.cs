using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class OcError
{
    public int OceId { get; set; }

    public int OceApdid { get; set; }

    public DateTime? OceCreateDate { get; set; }

    public int OceOperatorId { get; set; }

    public string? OceMessage { get; set; }

    public string? OceUri { get; set; }
}
