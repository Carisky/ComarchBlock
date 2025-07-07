using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class CrmsrsKontrahenci
{
    public int CskSseNumer { get; set; }

    public short CskSseLp { get; set; }

    public int CskKnSnumer { get; set; }

    public short CskKnSlp { get; set; }

    public virtual SrsElem SrsElem { get; set; } = null!;
}
