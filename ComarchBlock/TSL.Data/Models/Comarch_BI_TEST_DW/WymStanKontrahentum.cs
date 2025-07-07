using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymStanKontrahentum
{
    public int SktRowId { get; set; }

    public int SktId { get; set; }

    public int SktZrodid { get; set; }

    public string SktCleanOrgId { get; set; } = null!;

    public string SktDirtyOrgId { get; set; } = null!;

    public string SktNazwa { get; set; } = null!;

    public string? SktOpis { get; set; }

    public string? SktParDirtyOrgId { get; set; }

    public string? SktParCleanOrgId { get; set; }

    public int? SktParGid { get; set; }

    public DateTime SktTsinsert { get; set; }

    public DateTime SktTsupdate { get; set; }

    public DateTime SktTimeFrom { get; set; }

    public DateTime? SktTimeTo { get; set; }

    public int SktChecksumKimball1 { get; set; }

    public int SktChecksumKimball2 { get; set; }

    public int SktUpdateTransformationId { get; set; }

    public int? SktUpdateSubTransformationId { get; set; }

    public int SktInsertTransformationId { get; set; }

    public int? SktInsertSubTransformationId { get; set; }

    public byte[] SktRowVersion { get; set; } = null!;

    public virtual ICollection<FktKonwersacje> FktKonwersacjes { get; set; } = new List<FktKonwersacje>();

    public virtual WymZrodloDanych SktZrod { get; set; } = null!;
}
