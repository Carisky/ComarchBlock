using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class WfDefStatKonc
{
    public int WdkWdzid { get; set; }

    public int WdkWdsid { get; set; }

    public string? WdkSql { get; set; }

    public int? WdkLp { get; set; }

    public string? WdkOpis { get; set; }

    public virtual WfDefZadanium WdkWdz { get; set; } = null!;
}
