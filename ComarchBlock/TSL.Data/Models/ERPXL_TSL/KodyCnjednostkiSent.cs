using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KodyCnjednostkiSent
{
    public int KcnjId { get; set; }

    public int? KcnjKcnid { get; set; }

    public string KcnjJm { get; set; } = null!;

    public virtual KodyCn? KcnjKcn { get; set; }
}
