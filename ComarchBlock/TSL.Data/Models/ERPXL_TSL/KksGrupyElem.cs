using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KksGrupyElem
{
    public int KgeKgnid { get; set; }

    public string KgeKonto { get; set; } = null!;

    public int? KgeOkres { get; set; }

    public byte? KgePomin { get; set; }

    public virtual KksGrupyNag KgeKgn { get; set; } = null!;
}
