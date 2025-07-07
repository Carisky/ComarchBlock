using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class KnfOdsetkiKbview
{
    public int KokbvTyp { get; set; }

    public DateTime KokbvOkresOd { get; set; }

    public DateTime KokbvOkresDo { get; set; }

    public decimal? KokbvStopa { get; set; }
}
