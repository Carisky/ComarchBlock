using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class RetroOdbiorcy
{
    public int RtOId { get; set; }

    public int? RtORtKid { get; set; }

    public short? RtOKntTyp { get; set; }

    public int? RtOKntFirma { get; set; }

    public int? RtOKntNumer { get; set; }

    public short? RtOKntLp { get; set; }

    public virtual RetroKarty? RtORtK { get; set; }
}
