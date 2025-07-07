using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymDelegacja
{
    public int DlgRowId { get; set; }

    public int DlgId { get; set; }

    public int DlgZrodgid { get; set; }

    public string DlgOrgId { get; set; } = null!;

    public string DlgDirtyOrgId { get; set; } = null!;

    public string DlgNazwa { get; set; } = null!;

    public string? DlgOpis { get; set; }

    public string? DlgParDirtyOrgId { get; set; }

    public string? DlgParCleanOrgId { get; set; }

    public int? DlgParGid { get; set; }

    public DateTime DlgTsinsert { get; set; }

    public DateTime DlgTsupdate { get; set; }

    public DateTime DlgTimeFrom { get; set; }

    public DateTime? DlgTimeTo { get; set; }

    public int DlgChecksumKimball1 { get; set; }

    public int DlgChecksumKimball2 { get; set; }

    public int DlgUpdateSubTransformationId { get; set; }

    public int? DlgUpdateTransformationId { get; set; }

    public int DlgInsertSubTransformationId { get; set; }

    public int? DlgInsertTransformationId { get; set; }

    public byte[] DlgRowVersion { get; set; } = null!;

    public string? DlgStatus { get; set; }

    public string? DlgRodzaj { get; set; }

    public string? DlgMiejsce { get; set; }

    public string? DlgCel { get; set; }

    public string? DlgPelnyNumer { get; set; }
}
