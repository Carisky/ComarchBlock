using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdPlanyMag
{
    public int PpmPplid { get; set; }

    public int PpmMagNumer { get; set; }

    public byte PpmMagDlaElem { get; set; }

    public virtual Magazyny PpmMagNumerNavigation { get; set; } = null!;

    public virtual ProdPlany PpmPpl { get; set; } = null!;
}
