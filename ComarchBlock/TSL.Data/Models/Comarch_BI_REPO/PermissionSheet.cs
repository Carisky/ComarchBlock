using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class PermissionSheet
{
    public int Id { get; set; }

    public string ServerName { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string? CubeName { get; set; }

    public string DimensionName { get; set; } = null!;

    public string HierarchyName { get; set; } = null!;

    public string HierarchyOrgin { get; set; } = null!;

    public byte[] RowVersion { get; set; } = null!;

    public DateTime? LastPropagationDate { get; set; }

    public virtual ICollection<PermissionsOlapMember> PermissionsOlapMembers { get; set; } = new List<PermissionsOlapMember>();
}
