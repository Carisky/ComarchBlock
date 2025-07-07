using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class AnElem
{
    public short AnEGidtyp { get; set; }

    public int? AnEGidfirma { get; set; }

    public int AnEGidnumer { get; set; }

    public short AnEGidlp { get; set; }

    public short? AnEAnZtyp { get; set; }

    public int? AnEAnZfirma { get; set; }

    public int? AnEAnZnumer { get; set; }

    public short? AnEAnZlp { get; set; }

    public short? AnEAnFtyp { get; set; }

    public int? AnEAnFfirma { get; set; }

    public int? AnEAnFnumer { get; set; }

    public short? AnEAnFlp { get; set; }

    public int? AnEWzgledny { get; set; }

    public string? AnEZmienna { get; set; }

    public virtual AnNag AnEGidnumerNavigation { get; set; } = null!;
}
