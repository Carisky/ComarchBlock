using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class CubesPermission
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? ServerName { get; set; }

    public string? DatabaseName { get; set; }

    public string? CubeName { get; set; }

    public virtual User1 User { get; set; } = null!;
}
