using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Rcpzapisy
{
    public int RcZId { get; set; }

    public DateTime RcZCzas { get; set; }

    public short RcZTyp { get; set; }

    public short? RcZPrcTyp { get; set; }

    public int? RcZPrcNumer { get; set; }

    public int? RcZRcOid { get; set; }

    public short? RcZKorekta { get; set; }

    public int? RcZZrodlo { get; set; }

    public virtual PrcKarty? RcZPrcNumerNavigation { get; set; }

    public virtual Rcpopisy? RcZRcO { get; set; }

    public virtual ICollection<Rcpkorekty> Rcpkorekties { get; set; } = new List<Rcpkorekty>();
}
