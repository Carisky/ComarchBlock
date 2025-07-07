using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DynamicObjectsTranslation
{
    public int DbtRowId { get; set; }

    public int DbtId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int DbtZrodgid { get; set; }

    public string DbtOrgId { get; set; } = null!;

    public string DbtDirtyOrgId { get; set; } = null!;

    public string DbtName { get; set; } = null!;

    public string? DbtOpis { get; set; }

    public string? DbtParDirtyOrgId { get; set; }

    public string? DbtParCleanOrgId { get; set; }

    public int? DbtParGid { get; set; }

    public DateTime DbtTsinsert { get; set; }

    public DateTime DbtTsupdate { get; set; }

    public DateTime DbtTimeFrom { get; set; }

    public DateTime? DbtTimeTo { get; set; }

    public int DbtChecksumKimball1 { get; set; }

    public int DbtChecksumKimball2 { get; set; }

    public int DbtUpdateSubTransformationId { get; set; }

    public int? DbtUpdateTransformationId { get; set; }

    public int DbtInsertSubTransformationId { get; set; }

    public int? DbtInsertTransformationId { get; set; }

    public byte[] DbtRowVersion { get; set; } = null!;

    public int? DbtObjectId { get; set; }

    public string? DbtObjectType { get; set; }

    public int? DbtObjectTypeLevel { get; set; }

    public string? DbtLanguageCode { get; set; }

    public string? DbtTranslationValue { get; set; }

    public string? DbtObjectKey { get; set; }

    public virtual WymZrodloDanych DbtZrodg { get; set; } = null!;
}
