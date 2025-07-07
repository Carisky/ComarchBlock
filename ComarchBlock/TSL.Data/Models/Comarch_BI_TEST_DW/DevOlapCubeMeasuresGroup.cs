using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevOlapCubeMeasuresGroup
{
    public string CmgrId { get; set; } = null!;

    public string? CmgrOlapId { get; set; }

    public string? CmgrName { get; set; }

    public string? CmgrDescription { get; set; }

    public string? CmgrType { get; set; }

    public string? CmgrCubeReferenceId { get; set; }

    public string? CmgrTranslationId { get; set; }
}
