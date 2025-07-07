using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymRejon
{
    public int RejonChecksumKimball1 { get; set; }

    public int RejonChecksumKimball2 { get; set; }

    public string RejonDirtyOrgId { get; set; } = null!;

    public int RejonId { get; set; }

    public int? RejonInsertSubTransformationId { get; set; }

    public int RejonInsertTransformationId { get; set; }

    public string RejonNazwa { get; set; } = null!;

    public string? RejonOpis { get; set; }

    public string RejonOrgId { get; set; } = null!;

    public string? RejonParDirtyOrgId { get; set; }

    public int? RejonParGid { get; set; }

    public string? RejonParOrgId { get; set; }

    public int? RejonPracownikId { get; set; }

    public int? RejonRowId { get; set; }

    public byte[] RejonRowVersion { get; set; } = null!;

    public DateTime RejonTimeFrom { get; set; }

    public DateTime? RejonTimeTo { get; set; }

    public DateTime RejonTsinsert { get; set; }

    public DateTime RejonTsupdate { get; set; }

    public int? RejonUpdateSubTransformationId { get; set; }

    public int RejonUpdateTransformationId { get; set; }

    public int RejonZrodgid { get; set; }
}
