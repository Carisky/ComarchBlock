using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class InwArkTwr
{
    public int IatId { get; set; }

    public int? IatInAid { get; set; }

    public int? IatInAlp { get; set; }

    public int? IatInTid { get; set; }

    public decimal? IatIloscInw { get; set; }

    public virtual InwArk? IatInA { get; set; }
}
