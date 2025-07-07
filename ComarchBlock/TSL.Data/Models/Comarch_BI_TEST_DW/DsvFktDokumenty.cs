using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktDokumenty
{
    public string DokCleanOrgId { get; set; } = null!;

    public int DokCzdid { get; set; }

    public string DokDirtyOrgId { get; set; } = null!;

    public int DokDokNumerHandId { get; set; }

    public int DokDokNumerMagId { get; set; }

    public int DokDokNumerOfeId { get; set; }

    public int DokDokNumerZamId { get; set; }

    public int DokDokNumerZapOfeId { get; set; }

    public long DokId { get; set; }

    public int? DokInsertSubTransformationId { get; set; }

    public int DokInsertTransformationId { get; set; }

    public string? DokOpis { get; set; }

    public DateTime DokTsinsert { get; set; }

    public DateTime DokTsupdate { get; set; }

    public int? DokUpdateSubTransformationId { get; set; }

    public int DokUpdateTransformationId { get; set; }

    public int DokZrodgid { get; set; }
}
