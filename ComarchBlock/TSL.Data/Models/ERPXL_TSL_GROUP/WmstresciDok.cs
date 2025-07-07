using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class WmstresciDok
{
    public short WmDGidtyp { get; set; }

    public int WmDGidnumer { get; set; }

    public short WmDIdTresci { get; set; }

    public string? WmDSzczegoly { get; set; }
}
