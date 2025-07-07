using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktMagazynySrednieRuchyDokMag
{
    public int MsmId { get; set; }

    public int MsmAlokacjaId { get; set; }

    public decimal? MsmMsumIloscMag { get; set; }

    public decimal? MsmMiloscDniWmiesiacu { get; set; }

    public decimal? MsmMsrIloscMagazynowa { get; set; }

    public DateTime MsmTsupdate { get; set; }

    public DateTime MsmTsinsert { get; set; }

    public int? MsmInsertSubTransformationId { get; set; }

    public int MsmInsertTransformationId { get; set; }

    public int? MsmUpdateSubTransformationId { get; set; }

    public int MsmUpdateTransformationId { get; set; }

    public string? MsmOpis { get; set; }

    public string MsmDirtyOrgId { get; set; } = null!;

    public string MsmCleanOrgId { get; set; } = null!;

    public int MsmCzdgid { get; set; }

    public int MsmZrodgid { get; set; }

    public int? MsmCzmid { get; set; }

    public int? MsmProdId { get; set; }

    public int? MsmMagId { get; set; }

    public int? MsmJmId { get; set; }

    public int MsmPrmgid { get; set; }
}
