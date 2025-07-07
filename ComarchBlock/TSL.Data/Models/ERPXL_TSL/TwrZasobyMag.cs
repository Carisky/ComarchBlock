using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class TwrZasobyMag
{
    public int TzmTpaId { get; set; }

    public short? TzmMagTyp { get; set; }

    public int TzmMagNumer { get; set; }

    public int TzmMgAid { get; set; }

    public decimal? TzmIlosc { get; set; }

    public int TzmJednostkaLog { get; set; }

    public int TzmLp { get; set; }
}
