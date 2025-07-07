using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DevOlapCubeDimension
{
    public string CdimId { get; set; } = null!;

    public string? CdimOlapId { get; set; }

    public string? CdimName { get; set; }

    public string? CdimDescription { get; set; }

    public bool? CdimIsVisible { get; set; }

    public string? CdimOlapDimensionReferenceId { get; set; }

    public string? CdimCubeReferenceId { get; set; }

    public string? CdimTranslationId { get; set; }
}
