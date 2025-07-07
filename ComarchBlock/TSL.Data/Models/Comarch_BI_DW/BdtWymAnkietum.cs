using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymAnkietum
{
    public int AnkId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? AnkRowId { get; set; }

    public string? AnkRodzaj { get; set; }

    public string? AnkAnonimowa { get; set; }

    public byte[] AnkRowVersion { get; set; } = null!;

    public int? AnkInsertTransformationId { get; set; }

    public int AnkInsertSubTransformationId { get; set; }

    public int? AnkUpdateTransformationId { get; set; }

    public int AnkUpdateSubTransformationId { get; set; }

    public int AnkChecksumKimball2 { get; set; }

    public int AnkChecksumKimball1 { get; set; }

    public DateTime? AnkTimeTo { get; set; }

    public DateTime AnkTimeFrom { get; set; }

    public DateTime AnkTsupdate { get; set; }

    public DateTime AnkTsinsert { get; set; }

    public int? AnkParGid { get; set; }

    public string? AnkParCleanOrgId { get; set; }

    public string? AnkParDirtyOrgId { get; set; }

    public string? AnkOpis { get; set; }

    public string? AnkNazwa { get; set; }

    public string AnkDirtyOrgId { get; set; } = null!;

    public string AnkOrgId { get; set; } = null!;

    public int AnkZrodgid { get; set; }
}
