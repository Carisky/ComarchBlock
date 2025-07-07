using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class UserInvitationToCompany
{
    public int UitcId { get; set; }

    public int UitcAccountActiveId { get; set; }

    public string? UitcEmail { get; set; }

    public string? UitcHash { get; set; }

    public int? UitcWorkModeId { get; set; }

    public virtual AccountActive UitcAccountActive { get; set; } = null!;

    public virtual WorkMode? UitcWorkMode { get; set; }
}
