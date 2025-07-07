using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class SocialProfile
{
    public int SopId { get; set; }

    public string SopOrgId { get; set; } = null!;

    public string? SopFriendlyName { get; set; }

    public string? SopImageUrl { get; set; }

    public string? SopProfileLink { get; set; }

    public int SopCompanyId { get; set; }

    public virtual Company SopCompany { get; set; } = null!;
}
