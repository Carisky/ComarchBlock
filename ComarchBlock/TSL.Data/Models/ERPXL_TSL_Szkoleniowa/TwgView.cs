using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class TwgView
{
    public int TgvGidNumer { get; set; }

    public short TgvGidTyp { get; set; }

    public string? TgvKod { get; set; }

    public string? TgvNazwa { get; set; }
}
