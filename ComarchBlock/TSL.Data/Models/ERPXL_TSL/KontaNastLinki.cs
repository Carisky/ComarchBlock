using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KontaNastLinki
{
    public int KliNastNumer { get; set; }

    public int? KliPoprzOkresId { get; set; }

    public int KliPoprzNumer { get; set; }
}
