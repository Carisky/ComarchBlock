using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class InwOdcTwr
{
    public int IotId { get; set; }

    public int? IotInOid { get; set; }

    public int? IotInOlp { get; set; }

    public short? IotTwrTyp { get; set; }

    public int? IotTwrFirma { get; set; }

    public int? IotTwrNumer { get; set; }

    public short? IotTwrLp { get; set; }

    public decimal? IotIlosc { get; set; }

    public short? IotCckTyp { get; set; }

    public int? IotCckFirma { get; set; }

    public int? IotCckNumer { get; set; }

    public short? IotCckLp { get; set; }

    public string? IotCecha { get; set; }

    public int? IotInTid { get; set; }

    public virtual InwOdc? IotInO { get; set; }

    public virtual InwTwr? IotInT { get; set; }
}
