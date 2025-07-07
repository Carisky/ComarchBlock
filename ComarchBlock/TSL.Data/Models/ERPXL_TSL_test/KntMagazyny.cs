using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class KntMagazyny
{
    public short KnMKntTyp { get; set; }

    public int KnMKntNumer { get; set; }

    public int KnMMagNumer { get; set; }

    public byte? KnMPulpitKnt { get; set; }

    public byte? KnMMobSpr { get; set; }

    public virtual Magazyny KnMMagNumerNavigation { get; set; } = null!;
}
