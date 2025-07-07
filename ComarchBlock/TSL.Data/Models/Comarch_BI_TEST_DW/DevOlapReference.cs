using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevOlapReference
{
    public string PrefId { get; set; } = null!;

    public string? PrefObjectType { get; set; }

    public string? PrefReferenceType { get; set; }

    public string? PrefValue { get; set; }

    public string? PrefValue2 { get; set; }

    public string? PrefValue3 { get; set; }
}
