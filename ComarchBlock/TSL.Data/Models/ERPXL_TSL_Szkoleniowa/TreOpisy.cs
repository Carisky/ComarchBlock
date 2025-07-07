using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class TreOpisy
{
    public short? TeOTreTyp { get; set; }

    public int? TeOTreFirma { get; set; }

    public int TeOTreNumer { get; set; }

    public short TeOTreLp { get; set; }

    public byte? TeOTyp { get; set; }

    public string? TeOOpis { get; set; }

    public int? TeOOpisCharset { get; set; }

    public virtual TraElem TraElem { get; set; } = null!;
}
