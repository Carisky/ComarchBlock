using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Rcpkorekty
{
    public int RcKRcZid { get; set; }

    public short RcKLp { get; set; }

    public DateTime RcKCzas { get; set; }

    public short RcKPrcTyp { get; set; }

    public int RcKPrcNumer { get; set; }

    public DateTime? RcKRcZczas { get; set; }

    public int? RcKRcZrcOid { get; set; }

    public short? RcKRcZtyp { get; set; }

    public virtual Rcpzapisy RcKRcZ { get; set; } = null!;

    public virtual Rcpopisy? RcKRcZrcO { get; set; }
}
