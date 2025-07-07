using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymLimityKontrahentum
{
    public int KlkRowId { get; set; }

    public int KlkId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int KlkZrodgid { get; set; }

    public string KlkOrgId { get; set; } = null!;

    public string KlkDirtyOrgId { get; set; } = null!;

    public string KlkNazwa { get; set; } = null!;

    public string? KlkOpis { get; set; }

    public string? KlkParDirtyOrgId { get; set; }

    public string? KlkParCleanOrgId { get; set; }

    public int? KlkParGid { get; set; }

    public DateTime KlkTsinsert { get; set; }

    public DateTime KlkTsupdate { get; set; }

    public DateTime KlkTimeFrom { get; set; }

    public DateTime? KlkTimeTo { get; set; }

    public int KlkChecksumKimball1 { get; set; }

    public int KlkChecksumKimball2 { get; set; }

    public int KlkUpdateSubTransformationId { get; set; }

    public int? KlkUpdateTransformationId { get; set; }

    public int KlkInsertSubTransformationId { get; set; }

    public int? KlkInsertTransformationId { get; set; }

    public byte[] KlkRowVersion { get; set; } = null!;

    public string? KlkDataOd { get; set; }

    public string? KlkDataDo { get; set; }

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual WymZrodloDanych KlkZrodg { get; set; } = null!;
}
