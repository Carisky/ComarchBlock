using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymCennik
{
    public int CennikChecksumKimball1 { get; set; }

    public int CennikChecksumKimball2 { get; set; }

    public string CennikDirtyOrgId { get; set; } = null!;

    public int CennikId { get; set; }

    public int? CennikInsertSubTransformationId { get; set; }

    public int CennikInsertTransformationId { get; set; }

    public string CennikNazwa { get; set; } = null!;

    public string? CennikOpis { get; set; }

    public string CennikOrgId { get; set; } = null!;

    public string? CennikParCleanOrgId { get; set; }

    public string? CennikParDirtyOrgId { get; set; }

    public int? CennikParGid { get; set; }

    public int? CennikRowId { get; set; }

    public byte[] CennikRowVersion { get; set; } = null!;

    public DateTime CennikTimeFrom { get; set; }

    public DateTime? CennikTimeTo { get; set; }

    public DateTime CennikTsinsert { get; set; }

    public DateTime CennikTsupdate { get; set; }

    public int? CennikUpdateSubTransformationId { get; set; }

    public int CennikUpdateTransformationId { get; set; }

    public int CennikZrodgid { get; set; }

    public int CennikDataObowiazywania { get; set; }

    public string? CennikNazwaCeny { get; set; }
}
