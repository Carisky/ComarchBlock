using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class SekTypySerie
{
    public int StsSdtid { get; set; }

    public int StsFrsId { get; set; }

    public string? StsSeriaSpd { get; set; }

    public string? StsSeriaSwd { get; set; }

    public string? StsSeriaSww { get; set; }

    public virtual SekDokTypy StsSdt { get; set; } = null!;
}
