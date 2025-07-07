using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymKosztyProdukcji
{
    public int KprdChecksumKimball1 { get; set; }

    public int KprdChecksumKimball2 { get; set; }

    public string KprdDirtyOrgId { get; set; } = null!;

    public int KprdId { get; set; }

    public int KprdInsertSubTransformationId { get; set; }

    public int? KprdInsertTransformationId { get; set; }

    public string KprdNazwa { get; set; } = null!;

    public string? KprdOpis { get; set; }

    public string KprdOrgId { get; set; } = null!;

    public string? KprdParCleanOrgId { get; set; }

    public string? KprdParDirtyOrgId { get; set; }

    public int? KprdParGid { get; set; }

    public int KprdRowId { get; set; }

    public byte[] KprdRowVersion { get; set; } = null!;

    public DateTime KprdTimeFrom { get; set; }

    public DateTime? KprdTimeTo { get; set; }

    public DateTime KprdTsinsert { get; set; }

    public DateTime KprdTsupdate { get; set; }

    public int KprdUpdateSubTransformationId { get; set; }

    public int? KprdUpdateTransformationId { get; set; }

    public int KprdZrodgid { get; set; }
}
