using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymFlotaTrasa
{
    /// <summary>
    /// Relation to dimension Pracownik
    /// </summary>
    public int FltPrcGid { get; set; }

    public int FltRowId { get; set; }

    public int FltId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int FltZrodgid { get; set; }

    public string FltOrgId { get; set; } = null!;

    public string FltDirtyOrgId { get; set; } = null!;

    public string? FltNazwa { get; set; }

    public string? FltOpis { get; set; }

    public string? FltParDirtyOrgId { get; set; }

    public string? FltParCleanOrgId { get; set; }

    public int? FltParGid { get; set; }

    public DateTime FltTsinsert { get; set; }

    public DateTime FltTsupdate { get; set; }

    public DateTime FltTimeFrom { get; set; }

    public DateTime? FltTimeTo { get; set; }

    public int FltChecksumKimball1 { get; set; }

    public int FltChecksumKimball2 { get; set; }

    public int FltUpdateSubTransformationId { get; set; }

    public int? FltUpdateTransformationId { get; set; }

    public int FltInsertSubTransformationId { get; set; }

    public int? FltInsertTransformationId { get; set; }

    public byte[] FltRowVersion { get; set; } = null!;

    public string? FltGodzinaRozpoczecia { get; set; }

    public string? FltGodzinaZakonczenia { get; set; }

    public string? FltTrasa { get; set; }

    public virtual ICollection<FktFlotum> FktFlota { get; set; } = new List<FktFlotum>();

    public virtual WymPracownik FltPrcG { get; set; } = null!;

    public virtual WymZrodloDanych FltZrodg { get; set; } = null!;
}
