using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ZestKsdefKontum
{
    public int ZkdkGidnumer { get; set; }

    public short ZkdkGidlp { get; set; }

    public short ZkdkSubGidlp { get; set; }

    public short ZkdkZkdklp { get; set; }

    public string? ZkdkKonto { get; set; }

    public string? ZkdkKlasaKonta { get; set; }

    public int? ZkdkZknnumer { get; set; }

    public string? ZkdkZknpozycja { get; set; }

    public virtual ZestKsdef ZestKsdef { get; set; } = null!;
}
