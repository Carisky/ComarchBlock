using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevOlapAttribute
{
    public string OatrId { get; set; } = null!;

    public string? OatrOlapId { get; set; }

    public string? OatrName { get; set; }

    public string? OatrDescription { get; set; }

    public bool? OatrIsVisible { get; set; }

    public bool? OatrIsEnable { get; set; }

    public string? OatrUsage { get; set; }

    public long? OatrEstimatedCount { get; set; }

    public string? OatrOrderBy { get; set; }

    public string? OatrOrderById { get; set; }

    public string? OatrInstanceSelection { get; set; }

    public string? OatrType { get; set; }

    public string? OatrViewReferenceId { get; set; }

    public string? OatrKeyColumnsTableReferenceId { get; set; }

    public string? OatrKeyColumnsReferenceId { get; set; }

    public string? OatrNameColumnTableReferenceId { get; set; }

    public string? OatrNameColumnReferenceId { get; set; }

    public string? OatrDimensionReferenceId { get; set; }

    public string? OatrTranslationId { get; set; }
}
