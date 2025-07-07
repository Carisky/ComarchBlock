using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymPlacaTyp
{
    public int PltRowId { get; set; }

    public int PltId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int PltZrodgid { get; set; }

    public string PltOrgId { get; set; } = null!;

    public string PltDirtyOrgId { get; set; } = null!;

    public string PltNazwa { get; set; } = null!;

    public string? PltOpis { get; set; }

    public string? PltParDirtyOrgId { get; set; }

    public string? PltParCleanOrgId { get; set; }

    public int? PltParGid { get; set; }

    public DateTime PltTsinsert { get; set; }

    public DateTime PltTsupdate { get; set; }

    public DateTime PltTimeFrom { get; set; }

    public DateTime? PltTimeTo { get; set; }

    public int PltChecksumKimball1 { get; set; }

    public int PltChecksumKimball2 { get; set; }

    public int PltUpdateSubTransformationId { get; set; }

    public int? PltUpdateTransformationId { get; set; }

    public int PltInsertSubTransformationId { get; set; }

    public int? PltInsertTransformationId { get; set; }

    public byte[] PltRowVersion { get; set; } = null!;

    public virtual ICollection<FktPracownikWyplaty> FktPracownikWyplaties { get; set; } = new List<FktPracownikWyplaty>();

    public virtual WymZrodloDanych PltZrodg { get; set; } = null!;
}
