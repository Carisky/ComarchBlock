using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class TwrPodm
{
    public int TwPId { get; set; }

    public short? TwPTwrTyp { get; set; }

    public int? TwPTwrFirma { get; set; }

    public int TwPTwrNumer { get; set; }

    public short TwPTwrLp { get; set; }

    public short? TwPZamTyp { get; set; }

    public int? TwPZamFirma { get; set; }

    public int TwPZamNumer { get; set; }

    public short? TwPZamLp { get; set; }

    public int TwPWarstwa { get; set; }

    public byte? TwPDokRodzaj { get; set; }

    public decimal? TwPPrzeliczM { get; set; }

    public decimal? TwPPrzeliczL { get; set; }

    public int? TwPCzasModyfikacji { get; set; }

    public short? TwPPozycja { get; set; }

    public int? TwPRodzajPowiazania { get; set; }

    public virtual ICollection<FrsZamienniki> FrsZamiennikis { get; set; } = new List<FrsZamienniki>();
}
