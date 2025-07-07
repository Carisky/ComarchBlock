using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class OpePulpity
{
    public int XldId { get; set; }

    public string? XldNazwa { get; set; }

    public int? XldOpeNumer { get; set; }

    public byte[]? XldDefinicja { get; set; }

    public byte? XldPredefiniowany { get; set; }

    public int? XldModuly { get; set; }

    public int? XldModuly2 { get; set; }

    public int? XldDomyslnyWmodule { get; set; }

    public int? XldDomyslnyWmodule2 { get; set; }
}
