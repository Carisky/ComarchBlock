using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class ESklepRocechy
{
    public int EscEscid { get; set; }

    public int EscTrEid { get; set; }

    public int EscTwRid { get; set; }

    public int EscCechaDeAid { get; set; }

    public string EscCechaWartosc { get; set; } = null!;
}
