using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktHarmonogramPlatnosciLoplaconychRat
{
    public int HmpId { get; set; }

    public int HmpZrodgid { get; set; }

    public int HmpCzdgid { get; set; }

    public string HmpOrgId { get; set; } = null!;

    public string HmpDirtyOrgId { get; set; } = null!;

    public string? HmpOpis { get; set; }

    public int? HmpUpdateTransformationId { get; set; }

    public int HmpUpdateSubTransformationId { get; set; }

    public int? HmpInsertTransformationId { get; set; }

    public int HmpInsertSubTransformationId { get; set; }

    public DateTime HmpTsinsert { get; set; }

    public DateTime HmpTsupdate { get; set; }

    public int HmpAlokacjaGid { get; set; }

    public int HmpBudzetGid { get; set; }

    public int HmpDataPlRatyId { get; set; }

    public int HmpDataWystawienia { get; set; }

    public int HmpDokNumerId { get; set; }

    public int HmpFormPlatId { get; set; }

    public int HmpKntId { get; set; }

    public int HmpUmnid { get; set; }

    public int HmpWalutaId { get; set; }

    public decimal? HmpMwartoscRaty { get; set; }
}
