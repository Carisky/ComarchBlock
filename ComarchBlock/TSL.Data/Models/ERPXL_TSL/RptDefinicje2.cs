using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class RptDefinicje2
{
    public int RpD2RpWid { get; set; }

    public int RpD2RpFid { get; set; }

    public int RpD2Id { get; set; }

    public string? RpD2Definicja { get; set; }

    public virtual RptFormaty2 RptFormaty2 { get; set; } = null!;
}
