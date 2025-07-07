using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class PrcHist
{
    public int PhiId { get; set; }

    public int? PhiPrcNumer { get; set; }

    public string? PhiNumerKarty { get; set; }

    public int? PhiDataOd { get; set; }

    public int? PhiDataDo { get; set; }

    public byte? PhiKartaPos { get; set; }
}
