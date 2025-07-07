using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Bokstatystyki
{
    public int BksId { get; set; }

    public int? BksKntNumer { get; set; }

    public int? BksStatus { get; set; }

    public int? BksOcena { get; set; }

    public DateTime? BksData { get; set; }

    public int? BksPrawa { get; set; }
}
