using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class PicoSzybkaSprzedaz
{
    public int PssPicoId { get; set; }

    public int PssTwgSyncId { get; set; }

    public short? PssPozycja { get; set; }

    public virtual PicoKonfig PssPico { get; set; } = null!;

    public virtual TwrGrupy PssTwgSync { get; set; } = null!;
}
