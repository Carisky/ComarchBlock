using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymRodzajWydatku
{
    public int RwdChecksumKimball1 { get; set; }

    public int RwdChecksumKimball2 { get; set; }

    public string RwdDirtyOrgId { get; set; } = null!;

    public int RwdId { get; set; }

    public int? RwdInsertSubTransformationId { get; set; }

    public int RwdInsertTransformationId { get; set; }

    public string RwdNazwa { get; set; } = null!;

    public string? RwdOpis { get; set; }

    public string RwdOrgId { get; set; } = null!;

    public string? RwdParCleanOrgId { get; set; }

    public string? RwdParDirtyOrgId { get; set; }

    public int? RwdParGid { get; set; }

    public int? RwdRowId { get; set; }

    public byte[] RwdRowVersion { get; set; } = null!;

    public DateTime RwdTimeFrom { get; set; }

    public DateTime? RwdTimeTo { get; set; }

    public DateTime RwdTsinsert { get; set; }

    public DateTime RwdTsupdate { get; set; }

    public int? RwdUpdateSubTransformationId { get; set; }

    public int RwdUpdateTransformationId { get; set; }

    public int RwdZrodgid { get; set; }
}
