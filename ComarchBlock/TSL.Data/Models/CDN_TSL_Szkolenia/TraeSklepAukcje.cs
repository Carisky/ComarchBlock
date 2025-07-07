using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TraeSklepAukcje
{
    public int TrEaTrEaid { get; set; }

    public int TrEaTrNid { get; set; }

    public string TrEaAukcjaTyp { get; set; } = null!;

    public string TrEaAukcjaTranId { get; set; } = null!;

    public string TrEaAukcjaLogin { get; set; } = null!;

    public string TrEaAukcje { get; set; } = null!;

    public string TrEaAukcjaDostawaId { get; set; } = null!;

    public string TrEaAukcjaLoginId { get; set; } = null!;

    public string TrEaAukcjaLoginSell { get; set; } = null!;

    public string TrEaAukcjaLoginSellId { get; set; } = null!;

    public byte TrEaAukcjaSmart { get; set; }

    public virtual TraNag TrEaTrN { get; set; } = null!;
}
