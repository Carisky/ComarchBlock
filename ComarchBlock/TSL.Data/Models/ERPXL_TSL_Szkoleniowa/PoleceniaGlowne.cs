using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PoleceniaGlowne
{
    public int PglId { get; set; }

    public string? PglTresc { get; set; }

    public string? PglSkrot { get; set; }

    public byte? PglRodzaj { get; set; }

    public string? PglOpis { get; set; }

    public int? PglPredefiniowaneId { get; set; }

    public string? PglNazwaGr { get; set; }

    public virtual ICollection<PoleceniaTozsame> PoleceniaTozsames { get; set; } = new List<PoleceniaTozsame>();
}
