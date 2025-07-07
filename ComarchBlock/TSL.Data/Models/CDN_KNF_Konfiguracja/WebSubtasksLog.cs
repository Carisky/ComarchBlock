using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class WebSubtasksLog
{
    public long StlStlid { get; set; }

    public long StlStaId { get; set; }

    public string StlMessage { get; set; } = null!;

    public int StlLogLevel { get; set; }

    public virtual WebSubtask StlSta { get; set; } = null!;
}
