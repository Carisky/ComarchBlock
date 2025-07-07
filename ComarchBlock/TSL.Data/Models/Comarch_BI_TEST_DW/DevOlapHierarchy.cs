using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevOlapHierarchy
{
    public string OhieId { get; set; } = null!;

    public string? OhieOlapId { get; set; }

    public string? OhieName { get; set; }

    public string? OhieDescription { get; set; }

    public string? OhieAllMemberName { get; set; }

    public string? OhieAllMemberTranslationId { get; set; }

    public string? OhieDimensionReferenceId { get; set; }

    public string? OhieTranslationId { get; set; }
}
