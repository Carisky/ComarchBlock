using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class TwrWzOpisy
{
    public short WtoGrpTyp { get; set; }

    public int? WtoGrpFirma { get; set; }

    public int WtoGrpNumer { get; set; }

    public short WtoGrpLp { get; set; }

    public byte? WtoTyp { get; set; }

    public string? WtoOpis { get; set; }

    public int WtoJezyk { get; set; }

    public virtual TwrWzorce TwrWzorce { get; set; } = null!;
}
