using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktRabatyRetro
{
    public int RetrorCzdgid { get; set; }

    public string RetrorDirtyOrgId { get; set; } = null!;

    public int RetrorFormPlatGid { get; set; }

    public int RetrorId { get; set; }

    public int RetrorInsertSubTransformationId { get; set; }

    public int? RetrorInsertTransformationId { get; set; }

    public int RetrorKntGid { get; set; }

    public int RetrorMagGid { get; set; }

    public decimal? RetrorMsumaIlosc { get; set; }

    public decimal? RetrorMsumaWartosc { get; set; }

    public decimal? RetrorMwartosc { get; set; }

    public string? RetrorOpis { get; set; }

    public string RetrorOrgId { get; set; } = null!;

    public int RetrorProdGid { get; set; }

    public int RetrorRetrogid { get; set; }

    public int RetrorSpdgid { get; set; }

    public DateTime RetrorTsinsert { get; set; }

    public DateTime RetrorTsupdate { get; set; }

    public int RetrorUpdateSubTransformationId { get; set; }

    public int? RetrorUpdateTransformationId { get; set; }

    public int RetrorZrodgid { get; set; }
}
