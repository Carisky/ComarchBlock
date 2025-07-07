using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class PermissionsOlapMember
{
    public int Id { get; set; }

    public int? ParentMemberId { get; set; }

    public int PermissionSheetId { get; set; }

    public string MemberUniqueName { get; set; } = null!;

    public string MemberCaption { get; set; } = null!;

    public string LevelName { get; set; } = null!;

    public short LevelNumber { get; set; }

    public byte[] RowVersion { get; set; } = null!;

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public virtual PermissionSheet PermissionSheet { get; set; } = null!;
}
