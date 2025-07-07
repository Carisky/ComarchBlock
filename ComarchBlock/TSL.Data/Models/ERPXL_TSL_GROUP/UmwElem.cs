using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class UmwElem
{
    public short UmEGidtyp { get; set; }

    public int? UmEGidfirma { get; set; }

    public int UmEGidnumer { get; set; }

    public short UmEGidlp { get; set; }

    public string? UmEKod { get; set; }

    public string? UmENazwa { get; set; }

    public int? UmEPozycja { get; set; }

    public short? UmEDokTyp { get; set; }

    public int? UmEDokNumer { get; set; }

    public short? UmEDokLp { get; set; }

    public string? UmEUwagi { get; set; }
}
