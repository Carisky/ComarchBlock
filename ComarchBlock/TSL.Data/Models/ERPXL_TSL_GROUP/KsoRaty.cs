using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class KsoRaty
{
    public int KsrId { get; set; }

    public int? KsrKsenumer { get; set; }

    public short? KsrKselp { get; set; }

    public int? KsrDataKsiegowaniaPlan { get; set; }

    public decimal? KsrKwota { get; set; }

    public byte? KsrZmodyfikowana { get; set; }

    public int? KsrDelnumer { get; set; }

    public short? KsrDellp { get; set; }

    public virtual KsoElem? KsoElem { get; set; }
}
