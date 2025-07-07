using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class KntRejony
{
    public short KnRKntTyp { get; set; }

    public int KnRKntNumer { get; set; }

    public int KnRRejon { get; set; }

    public int? KnRCzasPrzypisania { get; set; }

    public virtual KntKarty KnRKntNumerNavigation { get; set; } = null!;

    public virtual Rejony KnRRejonNavigation { get; set; } = null!;
}
