using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class SysAnalitycDimensionHierarchy
{
    public int DimensionRootId { get; set; }

    public string DimensionRootName { get; set; } = null!;

    public int? LevelCount { get; set; }
}
