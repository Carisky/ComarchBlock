using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class ApplicationUsersRole
{
    public int AurUserId { get; set; }

    public int AurRoleId { get; set; }

    public DateTime? AurDateFrom { get; set; }

    public DateTime? AurDateTo { get; set; }

    public virtual ApplicationRole AurRole { get; set; } = null!;

    public virtual User1 AurUser { get; set; } = null!;
}
