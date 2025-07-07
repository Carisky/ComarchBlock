using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class AnalizyBiparam
{
    public string AbpNazwa { get; set; } = null!;

    public int AbpParam { get; set; }

    public string AbpData { get; set; } = null!;

    public byte[] AbpTimestamp { get; set; } = null!;
}
