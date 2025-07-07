using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TwrCenyHistOdDo
{
    public short? TwrTyp { get; set; }

    public int? TwrNumer { get; set; }

    public short? TwrLp { get; set; }

    public string? Waluta { get; set; }

    public short? NrKursu { get; set; }

    public decimal? Wartosc { get; set; }

    public decimal? WartoscNetto { get; set; }

    public string? FlagaNb { get; set; }

    public string? Stawka { get; set; }

    public int? Od { get; set; }

    public int? Do { get; set; }
}
