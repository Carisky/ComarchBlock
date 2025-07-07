using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class LokalizacjeView
{
    public int LvLokid { get; set; }

    public string LvLokkod { get; set; } = null!;

    public string LvLoknazwa { get; set; } = null!;

    public short LvLoknieaktywny { get; set; }

    public string LvLokkonto { get; set; } = null!;
}
