using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TrwaleCzesci
{
    public int SrTcSrtCid { get; set; }

    public int? SrTcZestawId { get; set; }

    public int? SrTcCzescId { get; set; }

    public virtual Trwale? SrTcZestaw { get; set; }
}
