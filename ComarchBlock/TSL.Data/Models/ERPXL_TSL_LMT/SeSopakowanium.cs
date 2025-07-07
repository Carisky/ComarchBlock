using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SeSopakowanium
{
    public int SopId { get; set; }

    public int SopLp { get; set; }

    public string? SopRodzaj { get; set; }

    public string? SopZnaki { get; set; }

    public int? SopIlosc { get; set; }
}
