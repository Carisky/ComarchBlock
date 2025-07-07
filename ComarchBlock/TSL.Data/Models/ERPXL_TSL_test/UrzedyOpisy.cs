using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class UrzedyOpisy
{
    public short? UroGidtyp { get; set; }

    public int? UroGidfirma { get; set; }

    public int UroGidnumer { get; set; }

    public short? UroGidlp { get; set; }

    public string? UroOpis { get; set; }

    public virtual Urzedy UroGidnumerNavigation { get; set; } = null!;
}
