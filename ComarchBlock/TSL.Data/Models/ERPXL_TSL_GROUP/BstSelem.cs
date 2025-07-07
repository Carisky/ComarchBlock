using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class BstSelem
{
    public int BsSTwrNumer { get; set; }

    public int BsSBsNid { get; set; }

    public short BsSRodzaj { get; set; }

    public decimal? BsSIlosc { get; set; }

    public virtual BstElem BstElem { get; set; } = null!;
}
