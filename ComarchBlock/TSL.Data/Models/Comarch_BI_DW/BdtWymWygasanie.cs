using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymWygasanie
{
    public int WygId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? WygRowId { get; set; }

    public int? WygDo { get; set; }

    public int? WygOd { get; set; }

    public byte[] WygRowVersion { get; set; } = null!;

    public int? WygInsertTransformationId { get; set; }

    public int? WygInsertSubTransformationId { get; set; }

    public int? WygUpdateTransformationId { get; set; }

    public int? WygUpdateSubTransformationId { get; set; }

    public int WygChecksumKimball2 { get; set; }

    public int WygChecksumKimball1 { get; set; }

    public DateTime? WygTimeTo { get; set; }

    public DateTime WygTimeFrom { get; set; }

    public DateTime WygTsupdate { get; set; }

    public DateTime WygTsinsert { get; set; }

    public int? WygParGid { get; set; }

    public string? WygParCleanOrgId { get; set; }

    public string? WygParDirtyOrgId { get; set; }

    public string? WygOpis { get; set; }

    public string? WygNazwa { get; set; }

    public string WygDirtyOrgId { get; set; } = null!;

    public string WygOrgId { get; set; } = null!;

    public int WygZrodgid { get; set; }

    public int? WygTypId { get; set; }

    public string? WygTypOrgId { get; set; }
}
