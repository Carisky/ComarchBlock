using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class OfertySzablony
{
    public int OfdSzaOfdSzaId { get; set; }

    public string OfdSzaNazwa { get; set; } = null!;

    public byte OfdSzaSystemowy { get; set; }

    public byte OfdSzaKopiaEl { get; set; }

    public byte OfdSzaPodpisCyfrowy { get; set; }

    public string? OfdSzaBody { get; set; }

    public virtual ICollection<OfertySzablonyDomyslne> OfertySzablonyDomyslnes { get; set; } = new List<OfertySzablonyDomyslne>();
}
