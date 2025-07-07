using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktMagazynySrednieRuchyDokMag
{
    public int MsmAlokacjaId { get; set; }

    public string MsmCleanOrgId { get; set; } = null!;

    public int MsmCzdgid { get; set; }

    public int? MsmCzmid { get; set; }

    public string MsmDirtyOrgId { get; set; } = null!;

    public long MsmId { get; set; }

    public int? MsmInsertSubTransformationId { get; set; }

    public int MsmInsertTransformationId { get; set; }

    public int? MsmJmId { get; set; }

    public int? MsmMagId { get; set; }

    public decimal? MsmMiloscDniWmiesiacu { get; set; }

    public decimal? MsmMsrIloscMagazynowa { get; set; }

    public decimal? MsmMsumIloscMag { get; set; }

    public string? MsmOpis { get; set; }

    public int? MsmProdId { get; set; }

    public DateTime MsmTsinsert { get; set; }

    public DateTime MsmTsupdate { get; set; }

    public int? MsmUpdateSubTransformationId { get; set; }

    public int MsmUpdateTransformationId { get; set; }

    public int MsmZrodgid { get; set; }

    public int MsmPrmgid { get; set; }
}
