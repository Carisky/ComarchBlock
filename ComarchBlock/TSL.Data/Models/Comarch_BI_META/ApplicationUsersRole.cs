using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class ApplicationUsersRole
{
    public int AurUserId { get; set; }

    public int AurRoleId { get; set; }

    public DateTime? AurDateFrom { get; set; }

    public DateTime? AurDateTo { get; set; }

    public virtual ApplicationRole AurRole { get; set; } = null!;

    public virtual ApplicationUser AurUser { get; set; } = null!;
}
