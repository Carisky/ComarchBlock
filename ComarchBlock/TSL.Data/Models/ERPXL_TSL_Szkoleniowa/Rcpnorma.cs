using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Rcpnorma
{
    public DateTime RcNData { get; set; }

    public short RcNTyp { get; set; }

    public short RcNFrsTyp { get; set; }

    public int RcNFrsNumer { get; set; }

    public int? RcNRcOid { get; set; }

    public short RcNNorma { get; set; }

    public virtual Rcpopisy? RcNRcO { get; set; }
}
