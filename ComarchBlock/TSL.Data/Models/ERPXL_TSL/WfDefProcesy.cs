using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class WfDefProcesy
{
    public int WdpId { get; set; }

    public string? WdpNazwa { get; set; }

    public short? WdpTypObiektu { get; set; }

    public int? WdpPriorytet { get; set; }

    public byte? WdpStan { get; set; }

    public int? WdpWdgid { get; set; }

    public byte? WdpDozwoloneInneAkcje { get; set; }

    public byte? WdpPredefiniowany { get; set; }

    public virtual ICollection<WfDefStatusy> WfDefStatusies { get; set; } = new List<WfDefStatusy>();

    public virtual ICollection<WfDefZadanium> WfDefZadania { get; set; } = new List<WfDefZadanium>();
}
