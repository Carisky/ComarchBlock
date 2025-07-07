using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymFlotaUzytkownikStatus
{
    public int FlsChecksumKimball1 { get; set; }

    public int FlsChecksumKimball2 { get; set; }

    public string FlsDirtyOrgId { get; set; } = null!;

    public int FlsId { get; set; }

    public int FlsInsertSubTransformationId { get; set; }

    public int? FlsInsertTransformationId { get; set; }

    public string? FlsNazwa { get; set; }

    public string? FlsOpis { get; set; }

    public string FlsOrgId { get; set; } = null!;

    public string? FlsParCleanOrgId { get; set; }

    public string? FlsParDirtyOrgId { get; set; }

    public int? FlsParGid { get; set; }

    public int? FlsRowId { get; set; }

    public byte[] FlsRowVersion { get; set; } = null!;

    public string? FlsStatus { get; set; }

    public DateTime FlsTimeFrom { get; set; }

    public DateTime? FlsTimeTo { get; set; }

    public DateTime FlsTsinsert { get; set; }

    public DateTime FlsTsupdate { get; set; }

    public int FlsUpdateSubTransformationId { get; set; }

    public int? FlsUpdateTransformationId { get; set; }

    public int FlsZrodgid { get; set; }
}
