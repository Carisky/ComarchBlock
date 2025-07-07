using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class ZestKsiKol
{
    public int ZkkZkkid { get; set; }

    public int ZkkZknid { get; set; }

    public short ZkkLp { get; set; }

    public string ZkkNazwa { get; set; } = null!;

    public byte ZkkOkres { get; set; }

    public DateTime? ZkkDataOd { get; set; }

    public DateTime? ZkkDataDo { get; set; }

    public virtual ZestKsiNag ZkkZkn { get; set; } = null!;
}
