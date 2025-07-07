using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrwUrzWlasc
{
    public int SuwSrUid { get; set; }

    public short? SuwWlaTyp { get; set; }

    public int? SuwWlaNumer { get; set; }

    public int SuwDataDo { get; set; }

    public virtual SrwUrzadzenium SuwSrU { get; set; } = null!;
}
