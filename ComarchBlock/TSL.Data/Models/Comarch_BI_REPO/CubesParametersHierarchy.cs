using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class CubesParametersHierarchy
{
    public string CphCubeName { get; set; } = null!;

    public int CphParameterId { get; set; }

    public int CphHierarchyId { get; set; }

    public virtual Hierarchy1 CphHierarchy { get; set; } = null!;

    public virtual Parameter CphParameter { get; set; } = null!;
}
