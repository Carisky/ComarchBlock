using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class ESklepWaluty
{
    public int EswEswid { get; set; }

    public int EswEssid { get; set; }

    public string? EswWaluta { get; set; }

    public decimal EswKursL { get; set; }

    public decimal EswKursM { get; set; }

    public byte EswZkonfig { get; set; }

    public DateTime EswTsMod { get; set; }

    public virtual ESklepStanowiska EswEss { get; set; } = null!;
}
