using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class FrazyTlumaczenium
{
    public string? FztTlumaczenie { get; set; }

    public int FztIdjezyka { get; set; }

    public int FztIdfrazy { get; set; }

    public virtual Frazy FztIdfrazyNavigation { get; set; } = null!;

    public virtual Slowniki FztIdjezykaNavigation { get; set; } = null!;
}
