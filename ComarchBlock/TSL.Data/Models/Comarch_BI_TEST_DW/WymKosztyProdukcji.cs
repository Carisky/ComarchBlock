using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymKosztyProdukcji
{
    public int KprdRowId { get; set; }

    public int KprdId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int KprdZrodgid { get; set; }

    public string KprdOrgId { get; set; } = null!;

    public string KprdDirtyOrgId { get; set; } = null!;

    public string KprdNazwa { get; set; } = null!;

    public string? KprdOpis { get; set; }

    public string? KprdParDirtyOrgId { get; set; }

    public string? KprdParCleanOrgId { get; set; }

    public int? KprdParGid { get; set; }

    public DateTime KprdTsinsert { get; set; }

    public DateTime KprdTsupdate { get; set; }

    public DateTime KprdTimeFrom { get; set; }

    public DateTime? KprdTimeTo { get; set; }

    public int KprdChecksumKimball1 { get; set; }

    public int KprdChecksumKimball2 { get; set; }

    public int KprdUpdateSubTransformationId { get; set; }

    public int? KprdUpdateTransformationId { get; set; }

    public int KprdInsertSubTransformationId { get; set; }

    public int? KprdInsertTransformationId { get; set; }

    public byte[] KprdRowVersion { get; set; } = null!;

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZps { get; set; } = new List<FktProdukcjaZp>();

    public virtual WymZrodloDanych KprdZrodg { get; set; } = null!;
}
