using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TwrGrupyAtrybuty
{
    public int TwGaTwGaid { get; set; }

    public int TwGaDeAid { get; set; }

    public int? TwGaTwGid { get; set; }

    public string TwGaWartoscTxt { get; set; } = null!;

    public int? TwGaDabid { get; set; }

    public int? TwGaSourceId { get; set; }

    public short TwGaJezykId { get; set; }
}
