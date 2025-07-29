using System;
using System.Collections.Generic;

namespace ComarchBlock;

public partial class GroupModuleLimit
{
    public string GroupCode { get; set; } = null!;

    public string Module { get; set; } = null!;

    public int Hour { get; set; }

    public int MaxLicenses { get; set; }
}
