using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymRozpatrzenieReklamacji
{
    public int RekleChecksumKimball1 { get; set; }

    public int RekleChecksumKimball2 { get; set; }

    public string RekleDirtyOrgId { get; set; } = null!;

    public int RekleId { get; set; }

    public int? RekleInsertSubTransformationId { get; set; }

    public int RekleInsertTransformationId { get; set; }

    public string RekleNazwa { get; set; } = null!;

    public string? RekleOpis { get; set; }

    public string RekleOrgId { get; set; } = null!;

    public string? RekleParCleanOrgId { get; set; }

    public string? RekleParDirtyOrgId { get; set; }

    public int? RekleParGid { get; set; }

    public int? RekleRowId { get; set; }

    public byte[] RekleRowVersion { get; set; } = null!;

    public DateTime RekleTimeFrom { get; set; }

    public DateTime? RekleTimeTo { get; set; }

    public DateTime RekleTsinsert { get; set; }

    public DateTime RekleTsupdate { get; set; }

    public int? RekleUpdateSubTransformationId { get; set; }

    public int RekleUpdateTransformationId { get; set; }

    public int RekleZrodgid { get; set; }

    public string? RekleStatus { get; set; }
}
