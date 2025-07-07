using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktNarzedziowniaZuzyciaRuchy
{
    public int NzrNdzgid { get; set; }

    public int NzrDokNumerGid { get; set; }

    public int NzrId { get; set; }

    public int NzrCzdgid { get; set; }

    public int NzrZrodgid { get; set; }

    public string NzrOrgId { get; set; } = null!;

    public string NzrDirtyOrgId { get; set; } = null!;

    public string? NzrOpis { get; set; }

    public decimal? NzrProcent { get; set; }

    public decimal? NzrProcentProd { get; set; }

    public decimal? NzrProcentMat { get; set; }
}
