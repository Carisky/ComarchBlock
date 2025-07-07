using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PicoCenniki
{
    public int PcCId { get; set; }

    public short? PcCTwCtwrTyp { get; set; }

    public int? PcCTwCtwrNumer { get; set; }

    public short? PcCTwCtwrLp { get; set; }

    public int PcCPcKid { get; set; }

    public int? PcCTs { get; set; }

    public virtual PicoKonfig PcCPcK { get; set; } = null!;
}
