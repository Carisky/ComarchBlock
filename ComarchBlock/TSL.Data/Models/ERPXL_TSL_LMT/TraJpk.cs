using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TraJpk
{
    public short TrJTrNtyp { get; set; }

    public int? TrJTrNfirma { get; set; }

    public int TrJTrNnumer { get; set; }

    public short TrJTrNlp { get; set; }

    public string TrJWartosc { get; set; } = null!;
}
