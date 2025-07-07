using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevOlapDimension
{
    public string OdimId { get; set; } = null!;

    public string? OdimOlapId { get; set; }

    public string? OdimName { get; set; }

    public string? OdimDescription { get; set; }

    public string? OdimLanguage { get; set; }

    public string? OdimAllMemberName { get; set; }

    public string? OdimAllMemberTranslationId { get; set; }

    public string? OdimUnknownMember { get; set; }

    public string? OdimUnknownMemberTranslationId { get; set; }

    public string? OdimUnknownMemberBehavior { get; set; }

    public string? OdimStorageMode { get; set; }

    public string? OdimType { get; set; }

    public string? OdimViewReferenceId { get; set; }

    public string? OdimTranslationId { get; set; }
}
