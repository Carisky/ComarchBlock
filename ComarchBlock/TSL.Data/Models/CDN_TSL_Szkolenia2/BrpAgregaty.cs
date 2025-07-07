using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class BrpAgregaty
{
    public int BagBagId { get; set; }

    public int? BagBrpId { get; set; }

    public short? BagTyp { get; set; }

    public decimal? BagSaldoBosys { get; set; }

    public decimal? BagPrzychodySys { get; set; }

    public decimal? BagRozchodySys { get; set; }

    public virtual BnkRaporty? BagBrp { get; set; }
}
