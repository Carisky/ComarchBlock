using System;
using System.Collections.Generic;

namespace ComarchBlock;

public partial class ModuleLimit
{
    public string ModuleName { get; set; } = null!;

    public int MaxLicenses { get; set; }
}
