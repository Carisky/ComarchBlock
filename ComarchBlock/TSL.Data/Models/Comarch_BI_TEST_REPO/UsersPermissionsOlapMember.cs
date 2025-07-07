using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class UsersPermissionsOlapMember
{
    public int UserId { get; set; }

    public int OlapMemberId { get; set; }

    public bool IsPropagated { get; set; }

    public virtual PermissionsOlapMember OlapMember { get; set; } = null!;

    public virtual User1 User { get; set; } = null!;
}
