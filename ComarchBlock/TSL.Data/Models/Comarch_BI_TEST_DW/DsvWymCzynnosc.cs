using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymCzynnosc
{
    public int CznChecksumKimball1 { get; set; }

    public int CznChecksumKimball2 { get; set; }

    public string CznDirtyOrgId { get; set; } = null!;

    public int CznId { get; set; }

    public int? CznInsertSubTransformationId { get; set; }

    public int CznInsertTransformationId { get; set; }

    public string CznNazwa { get; set; } = null!;

    public string? CznOpis { get; set; }

    public string CznOrgId { get; set; } = null!;

    public string? CznParCleanOrgId { get; set; }

    public string? CznParDirtyOrgId { get; set; }

    public int? CznParGid { get; set; }

    public int? CznRowId { get; set; }

    public byte[] CznRowVersion { get; set; } = null!;

    public DateTime CznTimeFrom { get; set; }

    public DateTime? CznTimeTo { get; set; }

    public DateTime CznTsinsert { get; set; }

    public DateTime CznTsupdate { get; set; }

    public int? CznUpdateSubTransformationId { get; set; }

    public int CznUpdateTransformationId { get; set; }

    public int CznZrodgid { get; set; }

    public string? CznKod { get; set; }
}
