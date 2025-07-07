using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class AccountActive
{
    public int AccCompanyId { get; set; }

    public int AccWorkModeId { get; set; }

    public bool AccIsBlocked { get; set; }

    public DateTime AccDateTo { get; set; }

    public bool? AccIsDemo { get; set; }

    public bool AccIsStandardReportsAdded { get; set; }

    public int? AccModelDefinitionId { get; set; }

    public int AccId { get; set; }

    public bool? AccIsFirstLoginActionDone { get; set; }

    public double? AccDwsize { get; set; }

    public bool? AccDwisFull { get; set; }

    public virtual Company AccCompany { get; set; } = null!;

    public virtual DataModelsDefinition? AccModelDefinition { get; set; }

    public virtual WorkMode AccWorkMode { get; set; } = null!;

    public virtual ICollection<AccountActiveUser> AccountActiveUsers { get; set; } = new List<AccountActiveUser>();

    public virtual ICollection<UserInvitationToCompany> UserInvitationToCompanies { get; set; } = new List<UserInvitationToCompany>();
}
