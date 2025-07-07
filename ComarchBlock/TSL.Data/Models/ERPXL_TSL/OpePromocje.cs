using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class OpePromocje
{
    public int OpmId { get; set; }

    public int? OpmPrmId { get; set; }

    public int? OpmOpeNumer { get; set; }

    public decimal? OpmWartosc { get; set; }

    public virtual PrmKarty? OpmPrm { get; set; }
}
