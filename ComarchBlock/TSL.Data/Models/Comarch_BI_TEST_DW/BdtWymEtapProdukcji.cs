using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymEtapProdukcji
{
    public int EprId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? EprRowId { get; set; }

    public byte[] EprRowVersion { get; set; } = null!;

    public int? EprInsertSubTransformationId { get; set; }

    public int EprInsertTransformationId { get; set; }

    public int? EprUpdateSubTransformationId { get; set; }

    public int EprUpdateTransformationId { get; set; }

    public int EprChecksumKimball2 { get; set; }

    public int EprChecksumKimball1 { get; set; }

    public DateTime? EprTimeTo { get; set; }

    public DateTime EprTimeFrom { get; set; }

    public DateTime EprTsupdate { get; set; }

    public DateTime EprTsinsert { get; set; }

    public int? EprParGid { get; set; }

    public string? EprParCleanOrgId { get; set; }

    public string? EprParDirtyOrgId { get; set; }

    public string? EprOpis { get; set; }

    public string EprNazwa { get; set; } = null!;

    public string EprDirtyOrgId { get; set; } = null!;

    public string EprCleanOrgId { get; set; } = null!;

    public int EprZrodgid { get; set; }
}
