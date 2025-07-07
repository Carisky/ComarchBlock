using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PracPitKwoty
{
    public int PpkPpkid { get; set; }

    public int PpkPpmid { get; set; }

    public int PpkNumer { get; set; }

    public string PpkWartosc { get; set; } = null!;

    public virtual PracPitMy PpkPpm { get; set; } = null!;
}
