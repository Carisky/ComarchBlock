using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TwrAnaliza
{
    public int TwAOkresId { get; set; }

    public int TwAMagNumer { get; set; }

    public int TwATwrNumer { get; set; }

    public string? TwAKategoria { get; set; }

    public virtual TwrAnalizaOkre TwAOkres { get; set; } = null!;
}
