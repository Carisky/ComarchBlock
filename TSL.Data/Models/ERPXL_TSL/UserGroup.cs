using System;
using System.Collections.Generic;

namespace ComarchBlock;

public partial class UserGroup
{
    public string UserName { get; set; } = null!;

    public string? Group { get; set; }

    public string? WindowsUser { get; set; }
}
