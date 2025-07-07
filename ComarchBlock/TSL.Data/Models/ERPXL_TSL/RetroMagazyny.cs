using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class RetroMagazyny
{
    public int RtMRtKid { get; set; }

    public int RtMMagNumer { get; set; }

    public virtual RetroKarty RtMRtK { get; set; } = null!;
}
