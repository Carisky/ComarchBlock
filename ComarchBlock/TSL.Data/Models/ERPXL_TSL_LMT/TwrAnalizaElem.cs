using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TwrAnalizaElem
{
    public int TaeTanid { get; set; }

    public int TaeMagNumer { get; set; }

    public int TaeTwrNumer { get; set; }

    public string? TaeKatPrzed { get; set; }

    public string? TaeKatPo { get; set; }

    public int? TaeLp { get; set; }

    public virtual TwrAnalizaNag TaeTan { get; set; } = null!;

    public virtual TwrKarty TaeTwrNumerNavigation { get; set; } = null!;
}
