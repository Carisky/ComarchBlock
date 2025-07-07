using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class Module
{
    public int ModId { get; set; }

    public string ModName { get; set; } = null!;

    public string ModInternalName { get; set; } = null!;
}
