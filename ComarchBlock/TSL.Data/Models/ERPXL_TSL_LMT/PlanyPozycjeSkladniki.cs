using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class PlanyPozycjeSkladniki
{
    public int PpsPpoid { get; set; }

    public int PpsPsoid { get; set; }

    public virtual PlanyObciazeniaPozycje PpsPpo { get; set; } = null!;
}
