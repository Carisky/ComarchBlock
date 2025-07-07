using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class UserGroup
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int GroupId { get; set; }

    public int RowVer { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual User1 User { get; set; } = null!;
}
