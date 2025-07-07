using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ObiektyObce
{
    public int? OboIdSesji { get; set; }

    public int OboIdObiektu { get; set; }

    public short? OboGidtyp { get; set; }

    public int? OboGidfirma { get; set; }

    public int? OboGidnumer { get; set; }

    public short? OboGidlp { get; set; }

    public int? OboTsotwarty { get; set; }

    public byte? OboIdApi { get; set; }
}
