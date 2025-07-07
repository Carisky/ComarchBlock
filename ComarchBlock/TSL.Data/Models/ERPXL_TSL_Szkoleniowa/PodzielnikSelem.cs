using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PodzielnikSelem
{
    public short? PdsGidtyp { get; set; }

    public int? PdsGidfirma { get; set; }

    public int PdsGidnumer { get; set; }

    public int PdsGidlp { get; set; }

    public int PdsWmrid { get; set; }

    public string? PdsElement { get; set; }

    public byte PdsTypWymiaru { get; set; }

    public virtual PodzielnikElem PodzielnikElem { get; set; } = null!;
}
