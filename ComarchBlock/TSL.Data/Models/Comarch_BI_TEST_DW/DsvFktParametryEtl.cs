using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktParametryEtl
{
    public int PelCzdgid { get; set; }

    public string PelDirtyOrgId { get; set; } = null!;

    public int PelId { get; set; }

    public int? PelInsertSubTransformationId { get; set; }

    public int PelInsertTransformationId { get; set; }

    public string? PelOpis { get; set; }

    public string PelOrgId { get; set; } = null!;

    public int? PelProcesowanieOlap { get; set; }

    public DateTime PelTsinsert { get; set; }

    public DateTime PelTsupdate { get; set; }

    public int? PelUpdateSubTransformationId { get; set; }

    public int PelUpdateTransformationId { get; set; }

    public decimal? PelWspKredytowania { get; set; }

    public int PelZrodgid { get; set; }
}
