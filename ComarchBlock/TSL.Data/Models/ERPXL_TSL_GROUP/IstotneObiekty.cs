using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class IstotneObiekty
{
    public short IstGidtyp { get; set; }

    public int IstGidnumer { get; set; }

    public short IstGidlp { get; set; }

    public int IstOpeNumer { get; set; }

    public int? IstDataUzycia { get; set; }

    public int? IstLicznik { get; set; }

    public string? IstNazwa { get; set; }

    public string? IstIkona { get; set; }

    public byte? IstTryb { get; set; }
}
