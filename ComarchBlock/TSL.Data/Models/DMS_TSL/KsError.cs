using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class KsError
{
    public int KseId { get; set; }

    public int KseApdid { get; set; }

    public DateTime? KseCreateDate { get; set; }

    public int KseOperatorId { get; set; }

    public string? KseMessage { get; set; }
}
