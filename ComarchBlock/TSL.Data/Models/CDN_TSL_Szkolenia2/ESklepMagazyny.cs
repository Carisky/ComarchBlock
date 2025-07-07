using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class ESklepMagazyny
{
    public int EsmEsmid { get; set; }

    public int EsmMagId { get; set; }

    public int EsmEssid { get; set; }

    public byte EsmDomyslny { get; set; }

    public virtual ESklepStanowiska EsmEss { get; set; } = null!;
}
