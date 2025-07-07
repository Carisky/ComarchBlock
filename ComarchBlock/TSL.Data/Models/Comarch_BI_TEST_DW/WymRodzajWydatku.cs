using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymRodzajWydatku
{
    public int RwdRowId { get; set; }

    public int RwdId { get; set; }

    public int RwdZrodgid { get; set; }

    public string RwdOrgId { get; set; } = null!;

    public string RwdDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Nazwa rodzaju wydatku
    /// </summary>
    public string RwdNazwa { get; set; } = null!;

    /// <summary>
    /// Opis rodzaju wydatku
    /// </summary>
    public string? RwdOpis { get; set; }

    public string? RwdParDirtyOrgId { get; set; }

    public string? RwdParCleanOrgId { get; set; }

    public int? RwdParGid { get; set; }

    public DateTime RwdTsinsert { get; set; }

    public DateTime RwdTsupdate { get; set; }

    public DateTime RwdTimeFrom { get; set; }

    public DateTime? RwdTimeTo { get; set; }

    public int RwdChecksumKimball1 { get; set; }

    public int RwdChecksumKimball2 { get; set; }

    public int RwdUpdateTransformationId { get; set; }

    public int? RwdUpdateSubTransformationId { get; set; }

    public int RwdInsertTransformationId { get; set; }

    public int? RwdInsertSubTransformationId { get; set; }

    public byte[] RwdRowVersion { get; set; } = null!;

    public virtual ICollection<FktWydatki> FktWydatkis { get; set; } = new List<FktWydatki>();

    public virtual WymZrodloDanych RwdZrodg { get; set; } = null!;
}
