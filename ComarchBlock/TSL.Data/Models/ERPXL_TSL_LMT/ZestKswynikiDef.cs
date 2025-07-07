using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ZestKswynikiDef
{
    public int ZwdZkwnumer { get; set; }

    public short ZwdZkwlp { get; set; }

    public int ZwdZkwdataOd { get; set; }

    public int ZwdZkwdataDo { get; set; }

    public short ZwdZkwbufor { get; set; }

    public short ZwdZkdsubLp { get; set; }

    public decimal? ZwdWartosc { get; set; }

    public virtual ZestKswyniki ZestKswyniki { get; set; } = null!;
}
