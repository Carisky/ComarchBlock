using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class KntEsklepy
{
    public int KesKesid { get; set; }

    public int KesKntId { get; set; }

    public int KesESklepId { get; set; }

    public short KesTypCenyDomyslnej { get; set; }

    public virtual ESklepStanowiska KesESklep { get; set; } = null!;

    public virtual Kontrahenci KesKnt { get; set; } = null!;
}
