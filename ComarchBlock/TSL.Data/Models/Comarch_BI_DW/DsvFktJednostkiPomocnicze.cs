using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktJednostkiPomocnicze
{
    public int JpomId { get; set; }

    public int JpomZrodgid { get; set; }

    public int JpomCzdgid { get; set; }

    public string JpomOrgId { get; set; } = null!;

    public string JpomDirtyOrgId { get; set; } = null!;

    public string? JpomOpis { get; set; }

    public int? JpomUpdateTransformationId { get; set; }

    public int JpomUpdateSubTransformationId { get; set; }

    public int? JpomInsertTransformationId { get; set; }

    public int JpomInsertSubTransformationId { get; set; }

    public DateTime JpomTsinsert { get; set; }

    public DateTime JpomTsupdate { get; set; }

    public decimal? JpomMprzelicznik { get; set; }

    public int JpomBudzetGid { get; set; }

    public int JpomAlokacjaGid { get; set; }

    public int JpomPerspektywaGid { get; set; }

    public int JpomProdGid { get; set; }

    public int JpomJmGid { get; set; }
}
