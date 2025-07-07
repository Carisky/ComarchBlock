using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkUserLoginHistory
{
    public int UlhDcdid { get; set; }

    public DateTime UlhLoginDate { get; set; }

    public string? UlhUserLogin { get; set; }

    public int? UlhCmduserCompanyId { get; set; }
}
