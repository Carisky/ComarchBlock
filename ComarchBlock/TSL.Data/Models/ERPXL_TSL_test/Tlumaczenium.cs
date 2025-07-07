using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Tlumaczenium
{
    public short TlmTyp { get; set; }

    public int TlmNumer { get; set; }

    public short TlmLp { get; set; }

    public byte TlmPole { get; set; }

    public int TlmJezyk { get; set; }

    public string? TlmTekst { get; set; }
}
