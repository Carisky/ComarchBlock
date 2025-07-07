using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymTypKontrahentaEtap
{
    public int TkeRowId { get; set; }

    public int TkeId { get; set; }

    public int TkeZrodgid { get; set; }

    public string TkeOrgId { get; set; } = null!;

    public string TkeDirtyOrgId { get; set; } = null!;

    public string TkeNazwa { get; set; } = null!;

    public string? TkeOpis { get; set; }

    public string? TkeParDirtyOrgId { get; set; }

    public string? TkeParCleanOrgId { get; set; }

    public int? TkeParGid { get; set; }

    public DateTime TkeTsinsert { get; set; }

    public DateTime TkeTsupdate { get; set; }

    public DateTime TkeTimeFrom { get; set; }

    public DateTime? TkeTimeTo { get; set; }

    public int TkeChecksumKimball1 { get; set; }

    public int TkeChecksumKimball2 { get; set; }

    public int TkeUpdateTransformationId { get; set; }

    public int? TkeUpdateSubTransformationId { get; set; }

    public int TkeInsertTransformationId { get; set; }

    public int? TkeInsertSubTransformationId { get; set; }

    public byte[] TkeRowVersion { get; set; } = null!;

    public virtual ICollection<FktKonwersacje> FktKonwersacjes { get; set; } = new List<FktKonwersacje>();

    public virtual WymZrodloDanych TkeZrodg { get; set; } = null!;
}
