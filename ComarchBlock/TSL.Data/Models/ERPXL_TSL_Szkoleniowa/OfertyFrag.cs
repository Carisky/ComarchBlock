using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class OfertyFrag
{
    public int OfeOfeId { get; set; }

    public string? OfeTyp { get; set; }

    public string OfeNazwa { get; set; } = null!;

    public string? OfeBody { get; set; }
}
