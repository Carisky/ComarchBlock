using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class MagTwrObszary
{
    public int MtoMgOid { get; set; }

    public short MtoTwrTyp { get; set; }

    public int MtoTwrNumer { get; set; }

    public virtual MagObszary MtoMgO { get; set; } = null!;
}
