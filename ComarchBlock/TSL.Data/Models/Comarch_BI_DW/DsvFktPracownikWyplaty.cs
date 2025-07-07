using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktPracownikWyplaty
{
    public int KwtAlokacjaGid { get; set; }

    public int KwtBudzetGid { get; set; }

    public int KwtCzdgid { get; set; }

    public int KwtCzdrid { get; set; }

    public int KwtCzdzid { get; set; }

    public int KwtCzmid { get; set; }

    public string KwtDirtyOrgId { get; set; } = null!;

    public int KwtId { get; set; }

    public int KwtInsertSubTransformationId { get; set; }

    public int? KwtInsertTransformationId { get; set; }

    public int? KwtLokId { get; set; }

    public int KwtLplgid { get; set; }

    public decimal? KwtMkwota { get; set; }

    public decimal? KwtMkwotaBrutto { get; set; }

    public decimal? KwtMkwotaKosztyPracodawcy { get; set; }

    public decimal? KwtMkwotaNetto { get; set; }

    public string? KwtOpis { get; set; }

    public string KwtOrgId { get; set; } = null!;

    public int KwtPerspektywaId { get; set; }

    public int KwtPltgid { get; set; }

    public int? KwtPrcGid { get; set; }

    public int KwtPskgid { get; set; }

    public int? KwtStrFrmGid { get; set; }

    public DateTime KwtTsinsert { get; set; }

    public DateTime KwtTsupdate { get; set; }

    public int KwtUpdateSubTransformationId { get; set; }

    public int? KwtUpdateTransformationId { get; set; }

    public int KwtWktwypEleId { get; set; }

    public int KwtWktwypId { get; set; }

    public int KwtZrodgid { get; set; }

    public int KwtPumgid { get; set; }

    public decimal? KwtMkwotaCalkowita { get; set; }
}
