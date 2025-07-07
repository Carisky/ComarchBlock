using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ImtOdczytyElem
{
    public int IoeItoid { get; set; }

    public short IoeLp { get; set; }

    public int? IoeSrtNumer { get; set; }

    public string? IoeMiejsce { get; set; }

    public int? IoePrcNumer { get; set; }

    public byte? IoeIlosc { get; set; }

    public string? IoeUwagi { get; set; }

    public virtual ImtOdczyty IoeIto { get; set; } = null!;
}
