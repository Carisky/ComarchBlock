using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class BstMagazyny
{
    public int BsMBsNid { get; set; }

    public int BsMMagTyp { get; set; }

    public int BsMMagNumer { get; set; }

    public virtual BstNag BsMBsN { get; set; } = null!;
}
