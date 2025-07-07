using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymStatusProdukcji
{
    public int StpChecksumKimball1 { get; set; }

    public int StpChecksumKimball2 { get; set; }

    public string StpDirtyOrgId { get; set; } = null!;

    public int StpId { get; set; }

    public int? StpInsertSubTransformationId { get; set; }

    public int StpInsertTransformationId { get; set; }

    public string StpNazwa { get; set; } = null!;

    public string? StpOpis { get; set; }

    public string StpOrgId { get; set; } = null!;

    public string? StpParCleanOrgId { get; set; }

    public string? StpParDirtyOrgId { get; set; }

    public int? StpParGid { get; set; }

    public int? StpRowId { get; set; }

    public byte[] StpRowVersion { get; set; } = null!;

    public DateTime StpTimeFrom { get; set; }

    public DateTime? StpTimeTo { get; set; }

    public DateTime StpTsinsert { get; set; }

    public DateTime StpTsupdate { get; set; }

    public int? StpUpdateSubTransformationId { get; set; }

    public int StpUpdateTransformationId { get; set; }

    public int StpZrodgid { get; set; }
}
