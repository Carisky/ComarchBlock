using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PlanSprzedazyKnt
{
    public int PskPspId { get; set; }

    public short PskKntTyp { get; set; }

    public int PskKntNumer { get; set; }

    public virtual PlanSprzedazy PskPsp { get; set; } = null!;
}
