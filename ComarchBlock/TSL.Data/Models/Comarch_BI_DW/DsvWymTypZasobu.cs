using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymTypZasobu
{
    public int TzaChecksumKimball1 { get; set; }

    public int TzaChecksumKimball2 { get; set; }

    public string TzaDirtyOrgId { get; set; } = null!;

    public int TzaId { get; set; }

    public int? TzaInsertSubTransformationId { get; set; }

    public int TzaInsertTransformationId { get; set; }

    public string TzaNazwa { get; set; } = null!;

    public string? TzaOpis { get; set; }

    public string TzaOrgId { get; set; } = null!;

    public string? TzaParCleanOrgId { get; set; }

    public string? TzaParDirtyOrgId { get; set; }

    public int? TzaParGid { get; set; }

    public int? TzaRowId { get; set; }

    public byte[] TzaRowVersion { get; set; } = null!;

    public DateTime TzaTimeFrom { get; set; }

    public DateTime? TzaTimeTo { get; set; }

    public DateTime TzaTsinsert { get; set; }

    public DateTime TzaTsupdate { get; set; }

    public int? TzaUpdateSubTransformationId { get; set; }

    public int TzaUpdateTransformationId { get; set; }

    public int TzaZrodgid { get; set; }
}
