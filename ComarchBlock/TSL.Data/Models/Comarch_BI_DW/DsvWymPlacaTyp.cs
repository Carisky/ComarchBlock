using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymPlacaTyp
{
    public int PltChecksumKimball1 { get; set; }

    public int PltChecksumKimball2 { get; set; }

    public string PltDirtyOrgId { get; set; } = null!;

    public int PltId { get; set; }

    public int PltInsertSubTransformationId { get; set; }

    public int? PltInsertTransformationId { get; set; }

    public string PltNazwa { get; set; } = null!;

    public string? PltOpis { get; set; }

    public string PltOrgId { get; set; } = null!;

    public string? PltParCleanOrgId { get; set; }

    public string? PltParDirtyOrgId { get; set; }

    public int? PltParGid { get; set; }

    public int? PltRowId { get; set; }

    public byte[] PltRowVersion { get; set; } = null!;

    public DateTime PltTimeFrom { get; set; }

    public DateTime? PltTimeTo { get; set; }

    public DateTime PltTsinsert { get; set; }

    public DateTime PltTsupdate { get; set; }

    public int PltUpdateSubTransformationId { get; set; }

    public int? PltUpdateTransformationId { get; set; }

    public int PltZrodgid { get; set; }
}
