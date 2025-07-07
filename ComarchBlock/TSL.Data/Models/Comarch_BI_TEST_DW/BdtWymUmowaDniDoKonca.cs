using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymUmowaDniDoKonca
{
    public int UdkId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? UdkRowId { get; set; }

    public string? UdkTypOrgId { get; set; }

    public int? UdkDo { get; set; }

    public int? UdkOd { get; set; }

    public byte[] UdkRowVersion { get; set; } = null!;

    public int? UdkInsertTransformationId { get; set; }

    public int? UdkInsertSubTransformationId { get; set; }

    public int? UdkUpdateTransformationId { get; set; }

    public int? UdkUpdateSubTransformationId { get; set; }

    public int UdkChecksumKimball2 { get; set; }

    public int UdkChecksumKimball1 { get; set; }

    public DateTime? UdkTimeTo { get; set; }

    public DateTime UdkTimeFrom { get; set; }

    public DateTime UdkTsupdate { get; set; }

    public DateTime UdkTsinsert { get; set; }

    public int? UdkParGid { get; set; }

    public string? UdkParCleanOrgId { get; set; }

    public string? UdkParDirtyOrgId { get; set; }

    public string? UdkOpis { get; set; }

    public string UdkNazwa { get; set; } = null!;

    public string UdkDirtyOrgId { get; set; } = null!;

    public string UdkOrgId { get; set; } = null!;

    public int UdkZrodgid { get; set; }
}
