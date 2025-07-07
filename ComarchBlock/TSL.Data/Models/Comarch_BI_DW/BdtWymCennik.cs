using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymCennik
{
    public int CennikId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? CennikRowId { get; set; }

    public byte[] CennikRowVersion { get; set; } = null!;

    public int? CennikInsertSubTransformationId { get; set; }

    public int CennikInsertTransformationId { get; set; }

    public int? CennikUpdateSubTransformationId { get; set; }

    public int CennikUpdateTransformationId { get; set; }

    public int CennikChecksumKimball2 { get; set; }

    public int CennikChecksumKimball1 { get; set; }

    public DateTime? CennikTimeTo { get; set; }

    public DateTime CennikTimeFrom { get; set; }

    public DateTime CennikTsupdate { get; set; }

    public DateTime CennikTsinsert { get; set; }

    public int? CennikParGid { get; set; }

    public string? CennikParCleanOrgId { get; set; }

    public string? CennikParDirtyOrgId { get; set; }

    public string? CennikOpis { get; set; }

    public string CennikNazwa { get; set; } = null!;

    public string CennikDirtyOrgId { get; set; } = null!;

    public string CennikOrgId { get; set; } = null!;

    public int CennikZrodgid { get; set; }

    public int CennikDataObowiazywania { get; set; }

    public string? CennikNazwaCeny { get; set; }

    public int? CennikPodstawaMarzy { get; set; }

    public int? CennikStan { get; set; }

    public int? CennikRodzajCeny { get; set; }

    public string? CennikOrgAtrId { get; set; }
}
