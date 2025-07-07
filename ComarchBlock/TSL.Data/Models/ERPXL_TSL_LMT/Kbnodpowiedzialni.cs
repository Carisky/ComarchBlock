using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Kbnodpowiedzialni
{
    public int KbnoId { get; set; }

    public int? KbnoKbnnid { get; set; }

    public int? KbnoMagNumer { get; set; }

    public int? KbnoPrcNumer { get; set; }

    public decimal? KbnoProcentOdpowiedzialnosci { get; set; }

    public int? KbnoDataOd { get; set; }

    public int? KbnoDataDo { get; set; }

    public virtual Kbnnag? KbnoKbnn { get; set; }
}
