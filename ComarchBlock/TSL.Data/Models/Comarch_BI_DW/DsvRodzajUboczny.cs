using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvRodzajUboczny
{
    public int RdzubChecksumKimball1 { get; set; }

    public int RdzubChecksumKimball2 { get; set; }

    public string RdzubDirtyOrgId { get; set; } = null!;

    public int RdzubId { get; set; }

    public int RdzubInsertSubTransformationId { get; set; }

    public int? RdzubInsertTransformationId { get; set; }

    public string RdzubNazwa { get; set; } = null!;

    public string? RdzubOpis { get; set; }

    public string RdzubOrgId { get; set; } = null!;

    public string? RdzubParCleanOrgId { get; set; }

    public string? RdzubParDirtyOrgId { get; set; }

    public int? RdzubParGid { get; set; }

    public int RdzubRowId { get; set; }

    public byte[] RdzubRowVersion { get; set; } = null!;

    public DateTime RdzubTimeFrom { get; set; }

    public DateTime? RdzubTimeTo { get; set; }

    public DateTime RdzubTsinsert { get; set; }

    public DateTime RdzubTsupdate { get; set; }

    public int RdzubUpdateSubTransformationId { get; set; }

    public int? RdzubUpdateTransformationId { get; set; }

    public int RdzubZrodgid { get; set; }
}
