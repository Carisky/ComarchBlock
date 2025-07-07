using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class AktualizacjeStanowiska
{
    public int AktSId { get; set; }

    public string AktSHash { get; set; } = null!;

    public DateTime AktSData { get; set; }

    public string AktSStanowisko { get; set; } = null!;

    public string AktSOperator { get; set; } = null!;
}
