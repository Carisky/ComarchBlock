using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymFlotaTrasa
{
    public int FltChecksumKimball1 { get; set; }

    public int FltChecksumKimball2 { get; set; }

    public string FltDirtyOrgId { get; set; } = null!;

    public string? FltGodzinaRozpoczecia { get; set; }

    public string? FltGodzinaZakonczenia { get; set; }

    public int FltId { get; set; }

    public int FltInsertSubTransformationId { get; set; }

    public int? FltInsertTransformationId { get; set; }

    public string? FltNazwa { get; set; }

    public string? FltOpis { get; set; }

    public string FltOrgId { get; set; } = null!;

    public string? FltParCleanOrgId { get; set; }

    public string? FltParDirtyOrgId { get; set; }

    public int? FltParGid { get; set; }

    public int FltPrcGid { get; set; }

    public int? FltRowId { get; set; }

    public byte[] FltRowVersion { get; set; } = null!;

    public DateTime FltTimeFrom { get; set; }

    public DateTime? FltTimeTo { get; set; }

    public string? FltTrasa { get; set; }

    public DateTime FltTsinsert { get; set; }

    public DateTime FltTsupdate { get; set; }

    public int FltUpdateSubTransformationId { get; set; }

    public int? FltUpdateTransformationId { get; set; }

    public int FltZrodgid { get; set; }
}
