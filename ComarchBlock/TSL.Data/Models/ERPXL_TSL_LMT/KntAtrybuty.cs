using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class KntAtrybuty
{
    public short KnXGidtyp { get; set; }

    public int? KnXGidfirma { get; set; }

    public int KnXGidnumer { get; set; }

    public short KnXGidlp { get; set; }

    public string? KnXAtrybut { get; set; }

    public byte? KnXFormatA { get; set; }

    public int? KnXNumer { get; set; }
}
