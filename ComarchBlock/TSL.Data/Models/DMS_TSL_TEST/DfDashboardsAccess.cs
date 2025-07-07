using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfDashboardsAccess
{
    public int DbaBsbid { get; set; }

    public int DbaDcdid { get; set; }

    public bool DbaArchival { get; set; }

    public virtual DfDashboard DbaBsb { get; set; } = null!;
}
