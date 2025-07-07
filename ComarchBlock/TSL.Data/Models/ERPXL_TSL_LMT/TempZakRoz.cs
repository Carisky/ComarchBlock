using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TempZakRoz
{
    public short? TrnGidTyp { get; set; }

    public int TrnGidNumer { get; set; }

    public decimal? Trpkwota { get; set; }

    public decimal? Trppozostaje { get; set; }

    public decimal RozKwota { get; set; }

    public int? RozData { get; set; }
}
