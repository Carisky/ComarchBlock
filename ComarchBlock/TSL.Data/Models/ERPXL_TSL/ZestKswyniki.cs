using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ZestKswyniki
{
    public short? ZkwZketyp { get; set; }

    public int? ZkwZkefirma { get; set; }

    public int ZkwZkenumer { get; set; }

    public short ZkwZkelp { get; set; }

    public int ZkwDataOd { get; set; }

    public int ZkwDataDo { get; set; }

    public short ZkwBufor { get; set; }

    public decimal? ZkwWartosc { get; set; }

    public int? ZkwTsobliczenia { get; set; }

    public virtual ZestKselem ZestKselem { get; set; } = null!;

    public virtual ICollection<ZestKswynikiDef> ZestKswynikiDefs { get; set; } = new List<ZestKswynikiDef>();
}
