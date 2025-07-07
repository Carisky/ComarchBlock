using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ShippingLogNag
{
    public int SlnId { get; set; }

    public short? SlnTu { get; set; }

    public int? SlnDataStart { get; set; }

    public int? SlnDataKoniec { get; set; }

    public int? SlnPoziom { get; set; }

    public virtual ICollection<ShippingLogElem> ShippingLogElems { get; set; } = new List<ShippingLogElem>();
}
