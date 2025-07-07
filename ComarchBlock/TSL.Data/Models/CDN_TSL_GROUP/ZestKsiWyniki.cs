using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class ZestKsiWyniki
{
    public int ZkwZkwid { get; set; }

    public int? ZkwOobId { get; set; }

    public int ZkwZknid { get; set; }

    public int ZkwZkpid { get; set; }

    public int ZkwZkkid { get; set; }

    public decimal ZkwWartosc { get; set; }

    public virtual ZestKsiNag ZkwZkn { get; set; } = null!;
}
