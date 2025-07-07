using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktKseFLdokumentow
{
    public int KsfId { get; set; }

    public int KsfZrodgid { get; set; }

    public int KsfCzdgid { get; set; }

    public string KsfOrgId { get; set; } = null!;

    public string KsfDirtyOrgId { get; set; } = null!;

    public string? KsfOpis { get; set; }

    public int? KsfUpdateTransformationId { get; set; }

    public int KsfUpdateSubTransformationId { get; set; }

    public int? KsfInsertTransformationId { get; set; }

    public int KsfInsertSubTransformationId { get; set; }

    public DateTime KsfTsinsert { get; set; }

    public DateTime KsfTsupdate { get; set; }

    public int KsfAlokacjaGid { get; set; }

    public int KsfBudzetGid { get; set; }

    public int KsfKsefgid { get; set; }

    public int KsfDokNumerGid { get; set; }

    public decimal? KsfNetto { get; set; }

    public decimal? KsfBrutto { get; set; }
}
