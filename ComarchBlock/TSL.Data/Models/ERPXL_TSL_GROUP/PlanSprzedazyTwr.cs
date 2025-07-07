using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PlanSprzedazyTwr
{
    public int PstPspId { get; set; }

    public short PstTwrTyp { get; set; }

    public int PstTwrNumer { get; set; }

    public virtual PlanSprzedazy PstPsp { get; set; } = null!;
}
