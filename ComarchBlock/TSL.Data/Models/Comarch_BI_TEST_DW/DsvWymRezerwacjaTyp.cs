using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymRezerwacjaTyp
{
    public int ReTChecksumKimball1 { get; set; }

    public int ReTChecksumKimball2 { get; set; }

    public string ReTDirtyOrgId { get; set; } = null!;

    public int ReTId { get; set; }

    public int ReTInsertSubTransformationId { get; set; }

    public int? ReTInsertTransformationId { get; set; }

    public string ReTNazwa { get; set; } = null!;

    public string? ReTOpis { get; set; }

    public string ReTOrgId { get; set; } = null!;

    public string? ReTParCleanOrgId { get; set; }

    public string? ReTParDirtyOrgId { get; set; }

    public int? ReTParGid { get; set; }

    public int? ReTRowId { get; set; }

    public byte[] ReTRowVersion { get; set; } = null!;

    public DateTime ReTTimeFrom { get; set; }

    public DateTime? ReTTimeTo { get; set; }

    public DateTime ReTTsinsert { get; set; }

    public DateTime ReTTsupdate { get; set; }

    public int ReTUpdateSubTransformationId { get; set; }

    public int? ReTUpdateTransformationId { get; set; }

    public int ReTZrodgid { get; set; }
}
