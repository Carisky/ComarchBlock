using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class WfDefOpiekun
{
    public int WdoWdzid { get; set; }

    public short WdoOpityp { get; set; }

    public int WdoOpinumer { get; set; }

    public short? WdoPodCentra { get; set; }
}
