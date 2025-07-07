using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class RptParametry2
{
    public int RpP2RpWid { get; set; }

    public int RpP2RpFid { get; set; }

    public int RpP2Id { get; set; }

    public string? RpP2Parametry { get; set; }

    public virtual RptFormaty2 RptFormaty2 { get; set; } = null!;
}
