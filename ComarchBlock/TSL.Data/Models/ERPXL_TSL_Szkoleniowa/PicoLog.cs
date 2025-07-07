using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PicoLog
{
    public int PcLId { get; set; }

    public int PcLPcKid { get; set; }

    public short PcLObiTyp { get; set; }

    public int PcLObiNumer { get; set; }

    public int PcLObiektId { get; set; }

    public string? PcLObiektGuid { get; set; }

    public short? PcLObiektTyp { get; set; }

    public string? PcLKomentarz { get; set; }

    public string? PcLInfo { get; set; }

    public int? PcLTstamp { get; set; }

    public virtual PicoKonfig PcLPcK { get; set; } = null!;
}
