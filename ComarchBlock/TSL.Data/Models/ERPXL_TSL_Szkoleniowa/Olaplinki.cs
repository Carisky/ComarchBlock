using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Olaplinki
{
    public int OllOwiid { get; set; }

    public int OllOgrid { get; set; }

    public int? OllLp { get; set; }

    public virtual OlapGrupy OllOgr { get; set; } = null!;
}
