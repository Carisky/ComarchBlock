using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Konwersacje
{
    public int? KxlId { get; set; }

    public long KxlIdwiadomosci { get; set; }

    public int? KxlOpeId { get; set; }

    public int? KxlDataiCzas { get; set; }

    public string? KxlTresc { get; set; }
}
