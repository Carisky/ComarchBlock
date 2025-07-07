using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class OfertySzablonyDomyslne
{
    public int OfdSdOfdSdid { get; set; }

    public int OfdSdOfdSzaId { get; set; }

    public int OfdSdOpeId { get; set; }

    public virtual OfertySzablony OfdSdOfdSza { get; set; } = null!;

    public virtual Operatorzy OfdSdOpe { get; set; } = null!;
}
