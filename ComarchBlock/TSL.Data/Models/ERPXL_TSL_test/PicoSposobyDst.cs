using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PicoSposobyDst
{
    public int PsdPicoId { get; set; }

    public short PsdSposobTyp { get; set; }

    public short PsdSposobLp { get; set; }

    public byte? PsdImpPotwZam { get; set; }

    public byte? PsdImpPotwOfe { get; set; }

    public virtual Nazwy Nazwy { get; set; } = null!;

    public virtual PicoKonfig PsdPico { get; set; } = null!;
}
