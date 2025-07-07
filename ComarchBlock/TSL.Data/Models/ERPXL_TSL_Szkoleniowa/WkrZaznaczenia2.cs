using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class WkrZaznaczenia2
{
    public string WkZ2Guid { get; set; } = null!;

    public int WkZ2RekordLp { get; set; }

    public short? WkZ2Gidtyp { get; set; }

    public int? WkZ2Gidfirma { get; set; }

    public int? WkZ2Gidnumer { get; set; }

    public short? WkZ2Gidlp { get; set; }
}
