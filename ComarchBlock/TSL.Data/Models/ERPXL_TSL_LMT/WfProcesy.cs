using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class WfProcesy
{
    public int WfpId { get; set; }

    public string? WfpNazwa { get; set; }

    public int? WfpWdpid { get; set; }

    public string? WfpOpis { get; set; }

    public int? WfpPriorytet { get; set; }

    public string? WfpUrl { get; set; }

    public short? WfpObityp { get; set; }

    public int? WfpObinumer { get; set; }

    public short? WfpObilp { get; set; }

    public string? WfpNazwaObiektu { get; set; }

    public short? WfpPrcTyp { get; set; }

    public int? WfpPrcNumer { get; set; }

    public int? WfpDataUtworzenia { get; set; }

    public int? WfpDataZamkniecia { get; set; }

    public int? WfpZrdNumer { get; set; }

    public virtual ICollection<WfZadanium> WfZadania { get; set; } = new List<WfZadanium>();
}
