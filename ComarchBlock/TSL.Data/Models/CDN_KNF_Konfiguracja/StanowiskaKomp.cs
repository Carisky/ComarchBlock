using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class StanowiskaKomp
{
    public int StaStaId { get; set; }

    public string StaNazwa { get; set; } = null!;

    public virtual ICollection<Rcsesje> Rcsesjes { get; set; } = new List<Rcsesje>();
}
