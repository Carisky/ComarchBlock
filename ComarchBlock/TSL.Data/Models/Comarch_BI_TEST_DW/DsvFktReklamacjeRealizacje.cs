using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktReklamacjeRealizacje
{
    public int ReklrAlokacjaId { get; set; }

    public int ReklrCzdid { get; set; }

    public string ReklrDirtyOrgId { get; set; } = null!;

    public string? ReklrElemOrgId { get; set; }

    public int ReklrId { get; set; }

    public int? ReklrInsertSubTransformationId { get; set; }

    public int ReklrInsertTransformationId { get; set; }

    public string? ReklrOpis { get; set; }

    public string? ReklrOrgAtrId { get; set; }

    public string ReklrOrgId { get; set; } = null!;

    public int ReklrRkopid { get; set; }

    public DateTime ReklrTsinsert { get; set; }

    public DateTime ReklrTsupdate { get; set; }

    public int? ReklrUpdateSubTransformationId { get; set; }

    public int ReklrUpdateTransformationId { get; set; }

    public int ReklrZrodgid { get; set; }

    public int ReklrRkreid { get; set; }
}
