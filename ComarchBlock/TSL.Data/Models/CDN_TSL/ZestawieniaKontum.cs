using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class ZestawieniaKontum
{
    public int ZkaZkaId { get; set; }

    public int ZkaOobId { get; set; }

    public int ZkaZknid { get; set; }

    public int ZkaZkpid { get; set; }

    public int ZkaAccId { get; set; }

    public string ZkaFunkcja { get; set; } = null!;

    public string ZkaFunkcjaNorma { get; set; } = null!;

    public virtual Kontum ZkaAcc { get; set; } = null!;

    public virtual ZestKsiPoz ZkaZkp { get; set; } = null!;
}
