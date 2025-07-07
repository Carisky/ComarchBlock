using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class AddHierarchy
{
    public int HierId { get; set; }

    public string HierHierarchyName { get; set; } = null!;

    public string HierDimensionName { get; set; } = null!;

    public bool HierIsActive { get; set; }

    public string? HierTranslationPl { get; set; }

    public string? HierTranslationEn { get; set; }

    public string? HierTranslationFr { get; set; }

    public string? HierTranslationDe { get; set; }

    public bool HierToDelete { get; set; }

    public string? HierOrgUnit { get; set; }

    public bool HierIsDirty { get; set; }

    public bool HierIsEnabled { get; set; }

    public string? HierDsvname { get; set; }
}
