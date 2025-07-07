using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ZestKszmienne
{
    public short? ZkzGidtyp { get; set; }

    public int? ZkzGidfirma { get; set; }

    public int ZkzGidnumer { get; set; }

    public short ZkzGidlp { get; set; }

    public string? ZkzNazwa { get; set; }

    public byte? ZkzTypDat { get; set; }

    public int? ZkzDataOd { get; set; }

    public int? ZkzDataDo { get; set; }

    public byte? ZkzBufor { get; set; }

    public virtual ZestKswidok ZkzGidnumerNavigation { get; set; } = null!;
}
