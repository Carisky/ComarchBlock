using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ShippingLogElem
{
    public int SleId { get; set; }

    public int? SleNid { get; set; }

    public short? SleStatus { get; set; }

    public int? SleDataStart { get; set; }

    public short? SleUslugaTyp { get; set; }

    public string? SleOpis { get; set; }

    public int? SleDataKoniec { get; set; }

    public int? SleOjciec { get; set; }

    public virtual ShippingLogNag? SleN { get; set; }
}
