using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktNarzedziowniaZuzyciaStany
{
    public int NzsNdzgid { get; set; }

    public int NzsId { get; set; }

    public int NzsCzdgid { get; set; }

    public int NzsZrodgid { get; set; }

    public string NzsOrgId { get; set; } = null!;

    public string NzsDirtyOrgId { get; set; } = null!;

    public string? NzsOpis { get; set; }

    public decimal? NzsProcent { get; set; }
}
