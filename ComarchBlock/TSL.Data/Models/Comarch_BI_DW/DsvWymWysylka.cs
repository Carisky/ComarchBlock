using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymWysylka
{
    public int? WysyRowId { get; set; }

    public int WysyId { get; set; }

    public int WysyZrodgid { get; set; }

    public string WysyOrgId { get; set; } = null!;

    public string WysyDirtyOrgId { get; set; } = null!;

    public string? WysyParCleanOrgId { get; set; }

    public string? WysyParDirtyOrgId { get; set; }

    public int? WysyParGid { get; set; }

    public string WysyNumerObcy { get; set; } = null!;

    public string? WysyOpis { get; set; }

    public DateTime WysyTsinsert { get; set; }

    public DateTime WysyTsupdate { get; set; }

    public int? WysyUpdateTransformationId { get; set; }

    public int WysyUpdateSubTransformationId { get; set; }

    public int? WysyInsertTransformationId { get; set; }

    public int WysyInsertSubTransformationId { get; set; }

    public DateTime WysyTimeFrom { get; set; }

    public DateTime? WysyTimeTo { get; set; }

    public int WysyChecksumKimball1 { get; set; }

    public int WysyChecksumKimball2 { get; set; }

    public byte[] WysyRowVersion { get; set; } = null!;

    public string? WysyStan { get; set; }

    public string? WysyKurier { get; set; }

    public string? WysyStanPrzesylki { get; set; }

    public string? WysyPunktOdb { get; set; }

    public string? WysyRealizatorWysylki { get; set; }
}
