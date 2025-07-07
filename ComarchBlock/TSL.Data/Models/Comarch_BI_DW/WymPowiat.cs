using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymPowiat
{
    public int PowiatRowId { get; set; }

    public int PowiatId { get; set; }

    public int PowiatZrodgid { get; set; }

    public string PowiatOrgId { get; set; } = null!;

    public string PowiatDirtyOrgId { get; set; } = null!;

    public string PowiatNazwa { get; set; } = null!;

    public string? PowiatOpis { get; set; }

    public string? PowiatParDirtyOrgId { get; set; }

    public string? PowiatParCleanOrgId { get; set; }

    public int? PowiatParGid { get; set; }

    public DateTime PowiatTsinsert { get; set; }

    public DateTime PowiatTsupdate { get; set; }

    public DateTime PowiatTimeFrom { get; set; }

    public DateTime? PowiatTimeTo { get; set; }

    public int PowiatChecksumKimball1 { get; set; }

    public int PowiatChecksumKimball2 { get; set; }

    public int PowiatUpdateTransformationId { get; set; }

    public int? PowiatUpdateSubTransformationId { get; set; }

    public int PowiatInsertTransformationId { get; set; }

    public int? PowiatInsertSubTransformationId { get; set; }

    public byte[] PowiatRowVersion { get; set; } = null!;

    public int? PowiatAktywny { get; set; }
}
