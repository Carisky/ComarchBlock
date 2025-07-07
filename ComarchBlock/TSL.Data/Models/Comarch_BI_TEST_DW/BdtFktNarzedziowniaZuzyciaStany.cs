using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktNarzedziowniaZuzyciaStany
{
    public int NzsNdzgid { get; set; }

    public int NzsId { get; set; }

    public int NzsCzdgid { get; set; }

    public int NzsZrodgid { get; set; }

    public string NzsOrgId { get; set; } = null!;

    public string NzsDirtyOrgId { get; set; } = null!;

    public string? NzsOpis { get; set; }

    public DateTime NzsTsinsert { get; set; }

    public DateTime NzsTsupdate { get; set; }

    public int NzsUpdateSubTransformationId { get; set; }

    public int? NzsUpdateTransformationId { get; set; }

    public int NzsInsertSubTransformationId { get; set; }

    public int? NzsInsertTransformationId { get; set; }

    public decimal? NzsProcent { get; set; }
}
