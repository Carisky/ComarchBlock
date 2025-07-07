using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymTypZasobu
{
    public int TzaId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? TzaRowId { get; set; }

    public string? TzaOpis { get; set; }

    public string TzaNazwa { get; set; } = null!;

    public int TzaZrodgid { get; set; }

    public int TzaUpdateTransformationId { get; set; }

    public int? TzaUpdateSubTransformationId { get; set; }

    public DateTime TzaTsupdate { get; set; }

    public DateTime TzaTsinsert { get; set; }

    public DateTime? TzaTimeTo { get; set; }

    public DateTime TzaTimeFrom { get; set; }

    public byte[] TzaRowVersion { get; set; } = null!;

    public int? TzaParGid { get; set; }

    public string? TzaParDirtyOrgId { get; set; }

    public string? TzaParCleanOrgId { get; set; }

    public string TzaOrgId { get; set; } = null!;

    public int TzaInsertTransformationId { get; set; }

    public int? TzaInsertSubTransformationId { get; set; }

    public string TzaDirtyOrgId { get; set; } = null!;

    public int TzaChecksumKimball2 { get; set; }

    public int TzaChecksumKimball1 { get; set; }
}
