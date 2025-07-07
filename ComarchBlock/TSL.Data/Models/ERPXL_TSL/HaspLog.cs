using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class HaspLog
{
    public int HlgId { get; set; }

    public int? HlgCzas { get; set; }

    public string? HlgOperator { get; set; }

    public int? HlgKod { get; set; }

    public int? HlgParametr { get; set; }

    public string? HlgOpis { get; set; }
}
