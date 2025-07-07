using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class UrzadzeniaZewnetrzneObiekty
{
    public int UzoUzId { get; set; }

    public short UzoObiTyp { get; set; }

    public int UzoObiNumer { get; set; }

    public virtual UrzadzeniaZewnetrzne UzoUz { get; set; } = null!;
}
