using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class ContextsMapping
{
    public int CtmContextId { get; set; }

    public string CtmContextMapping { get; set; } = null!;

    public string CtmMappingName { get; set; } = null!;

    public int CtmId { get; set; }
}
