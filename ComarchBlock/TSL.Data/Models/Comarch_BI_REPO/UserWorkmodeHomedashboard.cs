using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class UserWorkmodeHomedashboard
{
    public int UwhUserId { get; set; }

    public int UwhWorkModeId { get; set; }

    public int UwhHomeReportId { get; set; }

    public int UwhId { get; set; }

    public int? UwhCompanyId { get; set; }

    public virtual Company? UwhCompany { get; set; }

    public virtual Report UwhHomeReport { get; set; } = null!;

    public virtual User1 UwhUser { get; set; } = null!;

    public virtual WorkMode UwhWorkMode { get; set; } = null!;
}
