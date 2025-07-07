using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class RetroProgi
{
    public int RtPId { get; set; }

    public int? RtPRtKid { get; set; }

    public decimal? RtPWartoscProgu { get; set; }

    public byte? RtPTypRabatu { get; set; }

    public decimal? RtPRabat { get; set; }

    public virtual RetroKarty? RtPRtK { get; set; }
}
