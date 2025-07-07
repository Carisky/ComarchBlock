using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktKursyWalut
{
    public int KrwCzdid { get; set; }

    public string KrwDirtyOrgId { get; set; } = null!;

    public int KrwId { get; set; }

    public int? KrwInsertSubTransformationId { get; set; }

    public int KrwInsertTransformationId { get; set; }

    public string? KrwOpis { get; set; }

    public string KrwOrgId { get; set; } = null!;

    public decimal? KrwSredniNbp { get; set; }

    public DateTime KrwTsinsert { get; set; }

    public DateTime KrwTsupdate { get; set; }

    public int? KrwUpdateSubTransformationId { get; set; }

    public int KrwUpdateTransformationId { get; set; }

    public int KrwWalutaId { get; set; }

    public int KrwZrodgid { get; set; }
}
