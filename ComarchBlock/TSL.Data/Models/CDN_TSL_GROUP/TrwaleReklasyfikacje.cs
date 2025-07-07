using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class TrwaleReklasyfikacje
{
    public int SrTrSrTrid { get; set; }

    public int SrTrSrTid { get; set; }

    public short SrTrRok { get; set; }

    public byte SrTrMiesiac { get; set; }

    public virtual Trwale SrTrSrT { get; set; } = null!;
}
