using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktZamienniki
{
    public int ZamId { get; set; }

    public int ZamAlokacjaId { get; set; }

    public int ZamZamiennikId { get; set; }

    public int ZamProdId { get; set; }

    public int? ZamPrzelicznikM { get; set; }

    public int? ZamPrzelicznikL { get; set; }

    public string? ZamRodzaj { get; set; }

    public DateTime ZamTsupdate { get; set; }

    public DateTime ZamTsinsert { get; set; }

    public int? ZamInsertSubTransformationId { get; set; }

    public int ZamInsertTransformationId { get; set; }

    public int? ZamUpdateSubTransformationId { get; set; }

    public int ZamUpdateTransformationId { get; set; }

    public string? ZamOpis { get; set; }

    public string ZamDirtyOrgId { get; set; } = null!;

    public string ZamOrgId { get; set; } = null!;

    public int ZamCzdid { get; set; }

    public int ZamZrodgid { get; set; }

    public int ZamPrmgid { get; set; }
}
