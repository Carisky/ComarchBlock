using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class PicoKontrahenci
{
    public int PktPcKid { get; set; }

    public int PktRodzajId { get; set; }

    public byte? PktDodawanie { get; set; }

    public byte? PktEdycja { get; set; }

    public virtual PicoKonfig PktPcK { get; set; } = null!;

    public virtual Slowniki PktRodzaj { get; set; } = null!;
}
