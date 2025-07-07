using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymRozpatrzenieReklamacji
{
    public int RekleRowId { get; set; }

    public int RekleId { get; set; }

    public int RekleZrodgid { get; set; }

    public string RekleOrgId { get; set; } = null!;

    public string RekleDirtyOrgId { get; set; } = null!;

    public string RekleNazwa { get; set; } = null!;

    public string? RekleOpis { get; set; }

    public string? RekleParDirtyOrgId { get; set; }

    public string? RekleParCleanOrgId { get; set; }

    public int? RekleParGid { get; set; }

    public DateTime RekleTsinsert { get; set; }

    public DateTime RekleTsupdate { get; set; }

    public DateTime RekleTimeFrom { get; set; }

    public DateTime? RekleTimeTo { get; set; }

    public int RekleChecksumKimball1 { get; set; }

    public int RekleChecksumKimball2 { get; set; }

    public int RekleUpdateTransformationId { get; set; }

    public int? RekleUpdateSubTransformationId { get; set; }

    public int RekleInsertTransformationId { get; set; }

    public int? RekleInsertSubTransformationId { get; set; }

    public byte[] RekleRowVersion { get; set; } = null!;

    public virtual ICollection<FktReklamacje> FktReklamacjes { get; set; } = new List<FktReklamacje>();

    public virtual WymZrodloDanych RekleZrodg { get; set; } = null!;
}
