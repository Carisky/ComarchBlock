using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Kpdzrodla
{
    public short KpdTrPtyp { get; set; }

    public int KpdTrPnumer { get; set; }

    public string KpdTrPlp { get; set; } = null!;

    public int? KpdR2parId { get; set; }

    public int KpdDzknumer { get; set; }

    public virtual Dziennik KpdDzknumerNavigation { get; set; } = null!;
}
