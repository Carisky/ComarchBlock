using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TrwaleMaska
{
    public int SrMSrMid { get; set; }

    public int SrMSrTid { get; set; }

    public int SrMRokMies { get; set; }

    public byte SrMTyp { get; set; }

    public virtual Trwale SrMSrT { get; set; } = null!;
}
