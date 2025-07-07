using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class SrsNotatki
{
    public int SrNSrNid { get; set; }

    public int SrNSrZid { get; set; }

    public int SrNLp { get; set; }

    public string SrNTresc { get; set; } = null!;

    public int? SrNSerwisantTyp { get; set; }

    public int? SrNSerwisantId { get; set; }

    public DateTime SrNDataDok { get; set; }

    public virtual SrsZlecenium SrNSrZ { get; set; } = null!;
}
