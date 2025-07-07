using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConf
{
    public int CId { get; set; }

    public string CKey { get; set; } = null!;

    public string? CValue { get; set; }

    public string? CLongvalue { get; set; }
}
