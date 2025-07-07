using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class OpisWymSelem
{
    public short OwsGidtyp { get; set; }

    public int? OwsGidfirma { get; set; }

    public int OwsGidnumer { get; set; }

    public short OwsGidlp { get; set; }

    public int OwsWmrid { get; set; }

    public string? OwsElement { get; set; }

    public short OwsTypWymiaru { get; set; }

    public virtual OpisWymElem OpisWymElem { get; set; } = null!;
}
