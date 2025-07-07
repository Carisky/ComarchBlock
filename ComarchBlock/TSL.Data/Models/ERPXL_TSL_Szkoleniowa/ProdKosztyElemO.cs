using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdKosztyElemO
{
    public int PkeoPkoid { get; set; }

    public short PkeoObiTyp { get; set; }

    public int PkeoObiNumer { get; set; }

    public virtual ProdKoszty PkeoPko { get; set; } = null!;
}
