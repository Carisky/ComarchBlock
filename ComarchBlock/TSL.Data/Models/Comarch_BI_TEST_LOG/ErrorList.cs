using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class ErrorList
{
    public int? EliErrorCode { get; set; }

    public string EliMessage { get; set; } = null!;

    public string? EliDescription { get; set; }

    public int EliTableLinkId { get; set; }

    public int EliId { get; set; }

    public string EliLanId { get; set; } = null!;
}
