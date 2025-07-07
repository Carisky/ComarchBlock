using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class RetroSpD
{
    public int RtSId { get; set; }

    public int? RtSRtKid { get; set; }

    public short? RtSSpDtyp { get; set; }

    public int? RtSSpDlp { get; set; }

    public virtual RetroKarty? RtSRtK { get; set; }
}
