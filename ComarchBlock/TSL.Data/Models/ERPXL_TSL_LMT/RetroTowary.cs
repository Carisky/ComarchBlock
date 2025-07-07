using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class RetroTowary
{
    public int RtTId { get; set; }

    public int? RtTRtKid { get; set; }

    public short? RtTTwrTyp { get; set; }

    public int? RtTTwrFirma { get; set; }

    public int? RtTTwrNumer { get; set; }

    public short? RtTTwrLp { get; set; }

    public byte? RtTTyp { get; set; }

    public virtual RetroKarty? RtTRtK { get; set; }
}
