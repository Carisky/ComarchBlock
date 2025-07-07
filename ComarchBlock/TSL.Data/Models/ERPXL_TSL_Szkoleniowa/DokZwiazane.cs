using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class DokZwiazane
{
    public short DozZrdtyp { get; set; }

    public int? DozZrdfirma { get; set; }

    public int DozZrdnumer { get; set; }

    public short DozZrdlp { get; set; }

    public short DozDoktyp { get; set; }

    public int? DozDokfirma { get; set; }

    public int DozDoknumer { get; set; }

    public short DozDoklp { get; set; }

    public int? DozDataZwiazania { get; set; }

    public byte? DozPobierzWymiarAnalit { get; set; }
}
