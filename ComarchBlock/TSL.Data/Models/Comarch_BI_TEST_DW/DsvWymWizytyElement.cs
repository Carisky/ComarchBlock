using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymWizytyElement
{
    public int WelChecksumKimball1 { get; set; }

    public int WelChecksumKimball2 { get; set; }

    public string WelDirtyOrgId { get; set; } = null!;

    public int WelId { get; set; }

    public int? WelInsertSubTransformationId { get; set; }

    public int WelInsertTransformationId { get; set; }

    public string? WelKod { get; set; }

    public string WelNazwa { get; set; } = null!;

    public string? WelOpis { get; set; }

    public string WelOrgId { get; set; } = null!;

    public string? WelParCleanOrgId { get; set; }

    public string? WelParDirtyOrgId { get; set; }

    public int? WelParGid { get; set; }

    public string? WelPowodNiewykonania { get; set; }

    public int? WelRowId { get; set; }

    public byte[] WelRowVersion { get; set; } = null!;

    public string? WelStatus { get; set; }

    public DateTime WelTimeFrom { get; set; }

    public DateTime? WelTimeTo { get; set; }

    public DateTime WelTsinsert { get; set; }

    public DateTime WelTsupdate { get; set; }

    public int? WelUpdateSubTransformationId { get; set; }

    public int WelUpdateTransformationId { get; set; }

    public int WelZrodgid { get; set; }
}
