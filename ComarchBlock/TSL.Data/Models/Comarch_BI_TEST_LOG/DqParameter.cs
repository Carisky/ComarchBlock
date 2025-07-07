using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class DqParameter
{
    public int DqpId { get; set; }

    public int? DqpDqrcode { get; set; }

    public string? DqpName { get; set; }

    public string? DqpDescription { get; set; }

    public string? DqpValue { get; set; }
}
