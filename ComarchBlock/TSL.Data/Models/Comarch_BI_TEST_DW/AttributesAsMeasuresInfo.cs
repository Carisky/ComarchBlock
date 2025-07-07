using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class AttributesAsMeasuresInfo
{
    public int AtmiRowId { get; set; }

    public int AtmiId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int AtmiZrodgid { get; set; }

    public string AtmiOrgId { get; set; } = null!;

    public string AtmiDirtyOrgId { get; set; } = null!;

    public string AtmiName { get; set; } = null!;

    public string? AtmiOpis { get; set; }

    public string? AtmiParDirtyOrgId { get; set; }

    public string? AtmiParCleanOrgId { get; set; }

    public int? AtmiParGid { get; set; }

    public DateTime AtmiTsinsert { get; set; }

    public DateTime AtmiTsupdate { get; set; }

    public DateTime AtmiTimeFrom { get; set; }

    public DateTime? AtmiTimeTo { get; set; }

    public int AtmiChecksumKimball1 { get; set; }

    public int AtmiChecksumKimball2 { get; set; }

    public int AtmiUpdateSubTransformationId { get; set; }

    public int? AtmiUpdateTransformationId { get; set; }

    public int AtmiInsertSubTransformationId { get; set; }

    public int? AtmiInsertTransformationId { get; set; }

    public byte[] AtmiRowVersion { get; set; } = null!;

    public string? AtmiObjectType { get; set; }

    public string? AtmiDataFormat { get; set; }

    public string? AtmiDividing { get; set; }

    public string? AtmiDividingFriendlyName { get; set; }

    public string? AtmiAggregationFriendlyName { get; set; }

    public string? AtmiFormatString { get; set; }

    public string? AtmiFormatStringFriendlyName { get; set; }

    public int? AtmiCorrectionDocument { get; set; }

    public string? AtmiCorrectionSign { get; set; }

    public int? AtmiEmptyFields { get; set; }

    public string? AtmiEmptyFieldsValue { get; set; }

    public string? AtmiAttributeClassName { get; set; }

    public string? AtmiMeasureFriendlyName { get; set; }

    public string? AtmiAttributeColumnName { get; set; }

    public int? AtmiObjectId { get; set; }

    public string? AtmiObjectKey { get; set; }

    public string? AtmiDescription { get; set; }

    public string? AtmiAggregation { get; set; }

    public virtual WymZrodloDanych AtmiZrodg { get; set; } = null!;
}
