using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class TwrStawkiVat
{
    public int TwVId { get; set; }

    public short? TwVTwrTyp { get; set; }

    public int? TwVTwrFirma { get; set; }

    public int? TwVTwrNumer { get; set; }

    public short? TwVTwrLp { get; set; }

    public string? TwVKraj { get; set; }

    public string? TwVGrupaPod { get; set; }

    public decimal? TwVStawkaPod { get; set; }

    public byte? TwVFlagaVat { get; set; }

    public decimal? TwVZrodlowa { get; set; }
}
