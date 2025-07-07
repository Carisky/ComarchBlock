using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktMagazynySrednie
{
    public long MsrId { get; set; }

    public int MsrAlokacjaId { get; set; }

    public decimal? MsrMsumWartoscKs { get; set; }

    public decimal? MsrMsrWartoscKs { get; set; }

    public decimal? MsrMsrIloscMag { get; set; }

    public decimal? MsrMsumIloscKs { get; set; }

    public decimal? MsrMsumIloscMag { get; set; }

    public decimal? MsrMiloscDniWmiesiacu { get; set; }

    public decimal? MsrMsrIloscKs { get; set; }

    public DateTime MsrTsupdate { get; set; }

    public DateTime MsrTsinsert { get; set; }

    public int? MsrInsertSubTransformationId { get; set; }

    public int MsrInsertTransformationId { get; set; }

    public int? MsrUpdateSubTransformationId { get; set; }

    public int MsrUpdateTransformationId { get; set; }

    public string? MsrOpis { get; set; }

    public string MsrDirtyOrgId { get; set; } = null!;

    public string MsrCleanOrgId { get; set; } = null!;

    public int MsrCzdgid { get; set; }

    public int MsrZrodgid { get; set; }

    public int MsrCechaId { get; set; }

    public int? MsrCzmid { get; set; }

    public int? MsrPartid { get; set; }

    public int? MsrProdId { get; set; }

    public int? MsrMagId { get; set; }

    public int? MsrDostId { get; set; }

    public int? MsrJmId { get; set; }

    public int MsrPrmgid { get; set; }
}
