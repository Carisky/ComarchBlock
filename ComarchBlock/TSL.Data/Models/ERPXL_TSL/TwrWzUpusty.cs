using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class TwrWzUpusty
{
    public short WtuGrpTyp { get; set; }

    public int? WtuGrpFirma { get; set; }

    public int WtuGrpNumer { get; set; }

    public short? WtuGrpLp { get; set; }

    public decimal WtuProg { get; set; }

    public decimal? WtuUpust { get; set; }

    public virtual TwrWzorce TwrWzorce { get; set; } = null!;
}
