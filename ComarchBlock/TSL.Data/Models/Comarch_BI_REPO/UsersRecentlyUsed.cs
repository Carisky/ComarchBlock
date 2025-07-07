using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class UsersRecentlyUsed
{
    public int UreUserId { get; set; }

    public int UreCompanyId { get; set; }

    public int UreReportId { get; set; }

    public DateTime UreDate { get; set; }

    public virtual Company UreCompany { get; set; } = null!;

    public virtual Report UreReport { get; set; } = null!;

    public virtual User1 UreUser { get; set; } = null!;
}
