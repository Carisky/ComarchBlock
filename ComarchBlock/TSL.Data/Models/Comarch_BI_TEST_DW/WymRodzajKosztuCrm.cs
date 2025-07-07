using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymRodzajKosztuCrm
{
    public int RkcRowId { get; set; }

    public int RkcId { get; set; }

    public int RkcZrodgid { get; set; }

    public string RkcOrgId { get; set; } = null!;

    public string RkcDirtyOrgId { get; set; } = null!;

    public string RkcNazwa { get; set; } = null!;

    public string? RkcOpis { get; set; }

    public string? RkcParDirtyOrgId { get; set; }

    public string? RkcParCleanOrgId { get; set; }

    public int? RkcParGid { get; set; }

    public DateTime RkcTsinsert { get; set; }

    public DateTime RkcTsupdate { get; set; }

    public DateTime RkcTimeFrom { get; set; }

    public DateTime? RkcTimeTo { get; set; }

    public int RkcChecksumKimball1 { get; set; }

    public int RkcChecksumKimball2 { get; set; }

    public int RkcUpdateTransformationId { get; set; }

    public int? RkcUpdateSubTransformationId { get; set; }

    public int RkcInsertTransformationId { get; set; }

    public int? RkcInsertSubTransformationId { get; set; }

    public byte[] RkcRowVersion { get; set; } = null!;

    public virtual WymZrodloDanych RkcZrodg { get; set; } = null!;
}
