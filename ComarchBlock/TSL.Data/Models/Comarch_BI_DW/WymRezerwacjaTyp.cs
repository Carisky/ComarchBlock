using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymRezerwacjaTyp
{
    public int ReTRowId { get; set; }

    public int ReTId { get; set; }

    public int ReTZrodgid { get; set; }

    public string ReTOrgId { get; set; } = null!;

    public string ReTDirtyOrgId { get; set; } = null!;

    public string ReTNazwa { get; set; } = null!;

    public string? ReTOpis { get; set; }

    public string? ReTParDirtyOrgId { get; set; }

    public string? ReTParCleanOrgId { get; set; }

    public int? ReTParGid { get; set; }

    public DateTime ReTTsinsert { get; set; }

    public DateTime ReTTsupdate { get; set; }

    public DateTime ReTTimeFrom { get; set; }

    public DateTime? ReTTimeTo { get; set; }

    public int ReTChecksumKimball1 { get; set; }

    public int ReTChecksumKimball2 { get; set; }

    public int ReTUpdateSubTransformationId { get; set; }

    public int? ReTUpdateTransformationId { get; set; }

    public int ReTInsertSubTransformationId { get; set; }

    public int? ReTInsertTransformationId { get; set; }

    public byte[] ReTRowVersion { get; set; } = null!;

    public virtual WymZrodloDanych ReTZrodg { get; set; } = null!;

    public virtual ICollection<WymRezerwacjaNumer> WymRezerwacjaNumers { get; set; } = new List<WymRezerwacjaNumer>();
}
