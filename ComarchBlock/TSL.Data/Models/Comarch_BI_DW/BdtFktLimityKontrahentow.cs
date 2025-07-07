using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktLimityKontrahentow
{
    public int KnlId { get; set; }

    public int KnlAlokacjaId { get; set; }

    public decimal? KnlMlimitPoTermSystemCentralaWaluta { get; set; }

    public decimal? KnlMlimitSystemCentralaWaluta { get; set; }

    public decimal? KnlMlimitPoTermSystemCentrala { get; set; }

    public decimal? KnlMlimitSystemCentrala { get; set; }

    public decimal? KnlMlimitPoTermSystemWaluta { get; set; }

    public decimal? KnlMlimitSystemWaluta { get; set; }

    public decimal? KnlMlimitPoTermSystem { get; set; }

    public decimal? KnlMlimitSystem { get; set; }

    public DateTime KnlTsupdate { get; set; }

    public DateTime KnlTsinsert { get; set; }

    public int? KnlInsertSubTransformationId { get; set; }

    public int KnlInsertTransformationId { get; set; }

    public int? KnlUpdateSubTransformationId { get; set; }

    public int KnlUpdateTransformationId { get; set; }

    public string? KnlOpis { get; set; }

    public string KnlDirtyOrgId { get; set; } = null!;

    public string KnlOrgId { get; set; } = null!;

    public int KnlCzdgid { get; set; }

    public int KnlZrodgid { get; set; }

    public int? KnlWalutaGid { get; set; }

    public int? KnlKntId { get; set; }
}
