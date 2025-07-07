using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktParametryEtl
{
    public int PelId { get; set; }

    public int? PelProcesowanieOlap { get; set; }

    public decimal? PelWspKredytowania { get; set; }

    public DateTime PelTsupdate { get; set; }

    public DateTime PelTsinsert { get; set; }

    public int? PelInsertSubTransformationId { get; set; }

    public int PelInsertTransformationId { get; set; }

    public int? PelUpdateSubTransformationId { get; set; }

    public int PelUpdateTransformationId { get; set; }

    public string? PelOpis { get; set; }

    public string PelDirtyOrgId { get; set; } = null!;

    public string PelOrgId { get; set; } = null!;

    public int PelCzdgid { get; set; }

    public int PelZrodgid { get; set; }
}
