using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktProdukcjaKalkulacje
{
    public int PkkAlokacjaGid { get; set; }

    public int PkkBudzetGid { get; set; }

    public int PkkId { get; set; }

    public int PkkZrodgid { get; set; }

    public int PkkCzdgid { get; set; }

    public string PkkOrgId { get; set; } = null!;

    public string PkkDirtyOrgId { get; set; } = null!;

    public string? PkkOpis { get; set; }

    public DateTime PkkTsinsert { get; set; }

    public DateTime PkkTsupdate { get; set; }

    public int PkkUpdateSubTransformationId { get; set; }

    public int? PkkUpdateTransformationId { get; set; }

    public int PkkInsertSubTransformationId { get; set; }

    public int? PkkInsertTransformationId { get; set; }

    public int PkkDokNumerZp { get; set; }

    public int PkkDokNumerRw { get; set; }

    public int PkkDokNumerPw { get; set; }

    public int PkkKlkgid { get; set; }

    public int PkkStrFrmGid { get; set; }

    public int PkkOddgid { get; set; }

    public int PkkTchgid { get; set; }

    public int PkkProdGid { get; set; }

    public int PkkCzdrozp { get; set; }

    public int PkkCzdzak { get; set; }

    public int PkkMagGid { get; set; }

    public int PkkMatGid { get; set; }

    public decimal? PkkIloscMaterialu { get; set; }

    public decimal? PkkKosztSymulacja1 { get; set; }

    public decimal? PkkKosztSymulacja2 { get; set; }

    public decimal? PkkIloscTechnologia { get; set; }
}
