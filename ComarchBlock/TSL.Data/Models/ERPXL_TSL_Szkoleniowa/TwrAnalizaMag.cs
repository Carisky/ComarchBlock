using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class TwrAnalizaMag
{
    public int TamTanid { get; set; }

    public int TamMagNumer { get; set; }

    public virtual TwrAnalizaNag TamTan { get; set; } = null!;
}
