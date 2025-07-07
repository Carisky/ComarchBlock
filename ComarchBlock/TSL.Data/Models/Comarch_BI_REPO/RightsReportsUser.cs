using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class RightsReportsUser
{
    public int RruReportId { get; set; }

    public int RruUserId { get; set; }

    public byte RruAccessRight { get; set; }

    public virtual Report RruReport { get; set; } = null!;

    public virtual User1 RruUser { get; set; } = null!;
}
