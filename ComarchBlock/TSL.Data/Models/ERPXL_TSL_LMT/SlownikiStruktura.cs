using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SlownikiStruktura
{
    public int SlsId { get; set; }

    public int? SlsPredefiniowany { get; set; }

    public int? SlsOid { get; set; }

    public int? SlsLp { get; set; }

    public string? SlsNazwa { get; set; }

    public int? SlsWartoscL1 { get; set; }
}
