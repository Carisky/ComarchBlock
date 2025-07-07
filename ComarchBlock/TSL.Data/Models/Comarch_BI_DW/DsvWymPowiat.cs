using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymPowiat
{
    public int? PowiatAktywny { get; set; }

    public int PowiatChecksumKimball1 { get; set; }

    public int PowiatChecksumKimball2 { get; set; }

    public string PowiatDirtyOrgId { get; set; } = null!;

    public int PowiatId { get; set; }

    public int? PowiatInsertSubTransformationId { get; set; }

    public int PowiatInsertTransformationId { get; set; }

    public string PowiatNazwa { get; set; } = null!;

    public string? PowiatOpis { get; set; }

    public string PowiatOrgId { get; set; } = null!;

    public string? PowiatParCleanOrgId { get; set; }

    public string? PowiatParDirtyOrgId { get; set; }

    public int? PowiatParGid { get; set; }

    public int? PowiatRowId { get; set; }

    public byte[] PowiatRowVersion { get; set; } = null!;

    public DateTime PowiatTimeFrom { get; set; }

    public DateTime? PowiatTimeTo { get; set; }

    public DateTime PowiatTsinsert { get; set; }

    public DateTime PowiatTsupdate { get; set; }

    public int? PowiatUpdateSubTransformationId { get; set; }

    public int PowiatUpdateTransformationId { get; set; }

    public int PowiatZrodgid { get; set; }
}
