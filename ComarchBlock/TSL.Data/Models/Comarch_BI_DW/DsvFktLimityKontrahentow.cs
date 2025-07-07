using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktLimityKontrahentow
{
    public int KnlAlokacjaId { get; set; }

    public int KnlCzdgid { get; set; }

    public string KnlDirtyOrgId { get; set; } = null!;

    public int KnlId { get; set; }

    public int? KnlInsertSubTransformationId { get; set; }

    public int KnlInsertTransformationId { get; set; }

    public int? KnlKntId { get; set; }

    public decimal? KnlMlimitPoTermSystem { get; set; }

    public decimal? KnlMlimitPoTermSystemCentrala { get; set; }

    public decimal? KnlMlimitPoTermSystemCentralaWaluta { get; set; }

    public decimal? KnlMlimitPoTermSystemWaluta { get; set; }

    public decimal? KnlMlimitSystem { get; set; }

    public decimal? KnlMlimitSystemCentrala { get; set; }

    public decimal? KnlMlimitSystemCentralaWaluta { get; set; }

    public decimal? KnlMlimitSystemWaluta { get; set; }

    public string? KnlOpis { get; set; }

    public string KnlOrgId { get; set; } = null!;

    public DateTime KnlTsinsert { get; set; }

    public DateTime KnlTsupdate { get; set; }

    public int? KnlUpdateSubTransformationId { get; set; }

    public int KnlUpdateTransformationId { get; set; }

    public int? KnlWalutaGid { get; set; }

    public int KnlZrodgid { get; set; }
}
