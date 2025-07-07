using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdPlanyTwG
{
    public int PpgPplid { get; set; }

    public int PpgTwGnumer { get; set; }

    public short? PpgTwGtyp { get; set; }

    public virtual ProdPlany PpgPpl { get; set; } = null!;
}
