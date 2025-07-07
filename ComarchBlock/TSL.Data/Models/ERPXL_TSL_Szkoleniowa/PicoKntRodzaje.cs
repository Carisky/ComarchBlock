using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PicoKntRodzaje
{
    public int PkrPcKid { get; set; }

    public int PkrRodzajId { get; set; }

    public byte? PkrImpPotwZam { get; set; }

    public byte? PkrImpPotwOfe { get; set; }

    public virtual PicoKonfig PkrPcK { get; set; } = null!;

    public virtual Slowniki PkrRodzaj { get; set; } = null!;
}
