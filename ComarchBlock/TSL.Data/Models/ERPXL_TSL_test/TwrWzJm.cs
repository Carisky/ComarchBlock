using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class TwrWzJm
{
    public short WtjGrpTyp { get; set; }

    public int? WtjGrpFirma { get; set; }

    public int WtjGrpNumer { get; set; }

    public short WtjGrpLp { get; set; }

    public short? WtjKcaTyp { get; set; }

    public int? WtjKcaFirma { get; set; }

    public int? WtjKcaNumer { get; set; }

    public short? WtjKcaLp { get; set; }

    public string? WtjJmZ { get; set; }

    public byte? WtjJmFormat { get; set; }

    public byte? WtjTypJm { get; set; }

    public byte? WtjCalkowita { get; set; }

    public decimal? WtjPrzeliczM { get; set; }

    public decimal? WtjPrzeliczL { get; set; }

    public decimal? WtjProg { get; set; }

    public byte? WtjObowiazek { get; set; }

    public int? WtjJednostkaLog { get; set; }

    public byte? WtjPulpitKnt { get; set; }

    public byte? WtjMobSpr { get; set; }

    public byte? WtjISklep { get; set; }

    public byte? WtjDzielWzwm { get; set; }

    public virtual TwrWzorce TwrWzorce { get; set; } = null!;
}
