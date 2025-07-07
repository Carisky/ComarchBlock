using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymRodzKosztuDod
{
    public int RkdRowId { get; set; }

    public int RkdId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int RkdZrodgid { get; set; }

    public string RkdOrgId { get; set; } = null!;

    public string RkdDirtyOrgId { get; set; } = null!;

    public string RkdNazwa { get; set; } = null!;

    public string? RkdOpis { get; set; }

    public string? RkdParDirtyOrgId { get; set; }

    public string? RkdParCleanOrgId { get; set; }

    public int? RkdParGid { get; set; }

    public DateTime RkdTsinsert { get; set; }

    public DateTime RkdTsupdate { get; set; }

    public DateTime RkdTimeFrom { get; set; }

    public DateTime? RkdTimeTo { get; set; }

    public int RkdChecksumKimball1 { get; set; }

    public int RkdChecksumKimball2 { get; set; }

    public int RkdUpdateSubTransformationId { get; set; }

    public int? RkdUpdateTransformationId { get; set; }

    public int RkdInsertSubTransformationId { get; set; }

    public int? RkdInsertTransformationId { get; set; }

    public byte[] RkdRowVersion { get; set; } = null!;

    public virtual WymZrodloDanych RkdZrodg { get; set; } = null!;
}
