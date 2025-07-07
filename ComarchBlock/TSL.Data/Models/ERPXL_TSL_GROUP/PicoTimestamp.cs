using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PicoTimestamp
{
    public int PcSId { get; set; }

    public int? PcSPcKid { get; set; }

    public short? PcSObityp { get; set; }

    public int? PcSTssynchr { get; set; }

    public int? PcSTssynchrPtw { get; set; }

    public string? PcSSkrot { get; set; }

    public string? PcSOpis { get; set; }

    public virtual PicoKonfig? PcSPcK { get; set; }
}
