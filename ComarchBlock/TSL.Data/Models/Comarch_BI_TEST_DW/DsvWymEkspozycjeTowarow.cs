using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymEkspozycjeTowarow
{
    public bool? EktAktywny { get; set; }

    public int EktChecksumKimball1 { get; set; }

    public int EktChecksumKimball2 { get; set; }

    public string EktDirtyOrgId { get; set; } = null!;

    public int EktId { get; set; }

    public int? EktInsertSubTransformationId { get; set; }

    public int EktInsertTransformationId { get; set; }

    public string EktNazwa { get; set; } = null!;

    public string? EktOpis { get; set; }

    public string EktOrgId { get; set; } = null!;

    public string? EktParCleanOrgId { get; set; }

    public string? EktParDirtyOrgId { get; set; }

    public int? EktParGid { get; set; }

    public int? EktRowId { get; set; }

    public byte[] EktRowVersion { get; set; } = null!;

    public string? EktSatus { get; set; }

    public DateTime EktTimeFrom { get; set; }

    public DateTime? EktTimeTo { get; set; }

    public DateTime EktTsinsert { get; set; }

    public DateTime EktTsupdate { get; set; }

    public int? EktUpdateSubTransformationId { get; set; }

    public int EktUpdateTransformationId { get; set; }

    public string? EktWartosc { get; set; }

    public int EktZrodgid { get; set; }
}
