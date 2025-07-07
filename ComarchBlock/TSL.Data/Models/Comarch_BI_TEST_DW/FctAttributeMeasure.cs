using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FctAttributeMeasure
{
    public long AtmId { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int AtmCzdgid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int AtmZrodgid { get; set; }

    public string AtmOrgId { get; set; } = null!;

    public string AtmDirtyOrgId { get; set; } = null!;

    public string? AtmOpis { get; set; }

    public DateTime AtmTsinsert { get; set; }

    public DateTime AtmTsupdate { get; set; }

    public int AtmUpdateSubTransformationId { get; set; }

    public int? AtmUpdateTransformationId { get; set; }

    public int AtmInsertSubTransformationId { get; set; }

    public int? AtmInsertTransformationId { get; set; }

    public string? AtmDataFormat { get; set; }

    public string? AtmDividing { get; set; }

    public string? AtmDividingFriendlyName { get; set; }

    public string? AtmAggregation { get; set; }

    public string? AtmAggregationFriendlyName { get; set; }

    public string? AtmFormatString { get; set; }

    public string? AtmFormatFriendlyName { get; set; }

    public bool? AtmCorrectionDocument { get; set; }

    public string? AtmCorrectionSign { get; set; }

    public bool? AtmEmptyFields { get; set; }

    public string? AtmEmptyFieldsValue { get; set; }

    public string? AtmFactIternalName { get; set; }

    public string? AtmAnaliticalCubeBiid { get; set; }

    public string? AtmAttributeClassName { get; set; }

    public string? AtmMeasureFriednlyName { get; set; }

    public int? AtmObjectTypeId { get; set; }

    public string? AtmAttributeColumnName { get; set; }

    public int? AtmObjectTypeElementId { get; set; }

    public string? AtmFactBiid { get; set; }

    public virtual WymCzasDzien AtmCzdg { get; set; } = null!;

    public virtual WymZrodloDanych AtmZrodg { get; set; } = null!;
}
