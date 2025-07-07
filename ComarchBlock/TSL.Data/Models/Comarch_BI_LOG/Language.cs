using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class Language
{
    public string LanId { get; set; } = null!;

    public int LanCodePage { get; set; }

    public string LanName { get; set; } = null!;

    public string? LanDescription { get; set; }
}
