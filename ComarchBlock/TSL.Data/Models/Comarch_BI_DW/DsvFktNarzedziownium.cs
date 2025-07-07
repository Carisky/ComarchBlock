using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktNarzedziownium
{
    public int NrzTerminWydania { get; set; }

    public int NrzPrcGid { get; set; }

    public int NrzNdzgid { get; set; }

    public int NrzTerminZdania { get; set; }

    public int NrzDokRwlikwidacji { get; set; }

    public int NrzDokRwzdania { get; set; }

    public int NrzDokRwwydania { get; set; }

    public int NrzId { get; set; }

    public int NrzZrodgid { get; set; }

    public int NrzCzdgid { get; set; }

    public string NrzOrgId { get; set; } = null!;

    public string NrzDirtyOrgId { get; set; } = null!;

    public string? NrzOpis { get; set; }

    public int? NrzCzasWydania { get; set; }

    public int? NrzPlanowanyCzasWydania { get; set; }
}
