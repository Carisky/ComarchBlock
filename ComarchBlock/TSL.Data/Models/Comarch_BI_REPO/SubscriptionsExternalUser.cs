using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class SubscriptionsExternalUser
{
    public int SeuId { get; set; }

    public string SeuEmail { get; set; } = null!;

    public string? SeuName { get; set; }

    public int? SeuCompanyId { get; set; }
}
