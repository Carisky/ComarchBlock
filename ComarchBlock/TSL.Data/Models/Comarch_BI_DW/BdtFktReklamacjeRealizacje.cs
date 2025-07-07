using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktReklamacjeRealizacje
{
    public int ReklrId { get; set; }

    public int ReklrAlokacjaId { get; set; }

    public string? ReklrOrgAtrId { get; set; }

    public string? ReklrElemOrgId { get; set; }

    public DateTime ReklrTsupdate { get; set; }

    public DateTime ReklrTsinsert { get; set; }

    public int? ReklrInsertSubTransformationId { get; set; }

    public int ReklrInsertTransformationId { get; set; }

    public int? ReklrUpdateSubTransformationId { get; set; }

    public int ReklrUpdateTransformationId { get; set; }

    public string? ReklrOpis { get; set; }

    public string ReklrDirtyOrgId { get; set; } = null!;

    public string ReklrOrgId { get; set; } = null!;

    public int ReklrCzdid { get; set; }

    public int ReklrZrodgid { get; set; }

    public int ReklrRkopid { get; set; }

    public int ReklrRkreid { get; set; }
}
