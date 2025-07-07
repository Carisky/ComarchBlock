using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class EdError
{
    public int EdrId { get; set; }

    public int EdrApdid { get; set; }

    public DateTime? EdrCreateDate { get; set; }

    public int EdrOperatorId { get; set; }

    public string? EdrMessage { get; set; }
}
