using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevOlapCubeMeasure
{
    public string CmeaId { get; set; } = null!;

    public string? CmeaOlapId { get; set; }

    public string? CmeaName { get; set; }

    public string? CmeaDescription { get; set; }

    public string? CmeaAggregation { get; set; }

    public string? CmeaDataFormat { get; set; }

    public string? CmeaFormatString { get; set; }

    public string? CmeaNullProcesing { get; set; }

    public string? CmeaViewReferenceId { get; set; }

    public string? CmeaColumnTableReferenceId { get; set; }

    public string? CmeaColumnReferenceId { get; set; }

    public string? CmeaMeasureGroupReferenceId { get; set; }

    public string? CmeaCubeReferenceId { get; set; }

    public string? CmeaTranslationId { get; set; }

    public bool? CmeaIsVisible { get; set; }
}
