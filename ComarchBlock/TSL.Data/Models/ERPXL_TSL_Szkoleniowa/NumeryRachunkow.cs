using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class NumeryRachunkow
{
    public int NrbId { get; set; }

    public short? NrbObTyp { get; set; }

    public int? NrbObNumer { get; set; }

    public string? NrbNrRachunkuZnorm { get; set; }
}
