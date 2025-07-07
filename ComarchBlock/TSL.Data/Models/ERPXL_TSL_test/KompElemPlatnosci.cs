using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class KompElemPlatnosci
{
    public int KmpKmeid { get; set; }

    public short KmpKmelp { get; set; }

    public short KmpKmpsubLp { get; set; }

    public short? KmpNalTrplp { get; set; }

    public short? KmpZobTrplp { get; set; }

    public virtual KompElem KompElem { get; set; } = null!;
}
