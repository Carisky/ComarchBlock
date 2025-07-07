using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class MagParJednostki
{
    public int MpjMpaid { get; set; }

    public int MpjJednostkaLog { get; set; }

    public int? MpjIloscMaks { get; set; }

    public virtual MagParAdr MpjMpa { get; set; } = null!;
}
