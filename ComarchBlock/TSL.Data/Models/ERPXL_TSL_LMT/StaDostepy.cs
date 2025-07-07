using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class StaDostepy
{
    public short StDStaTyp { get; set; }

    public int? StDStaFirma { get; set; }

    public int StDStaNumer { get; set; }

    public short StDStaLp { get; set; }

    public int StDRodzaj { get; set; }

    public int StDNumer { get; set; }

    public string? StDSeria { get; set; }

    public short? StDZrdTyp { get; set; }

    public int? StDZrdFirma { get; set; }

    public int? StDZrdNumer { get; set; }

    public short? StDZrdLp { get; set; }

    public string? StDWartosc { get; set; }
}
