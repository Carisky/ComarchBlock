using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class ZestawyRegul
{
    public int ZrgZrgId { get; set; }

    public string ZrgAkronim { get; set; } = null!;

    public string ZrgNazwa { get; set; } = null!;

    public virtual ICollection<Dzialy> Dzialies { get; set; } = new List<Dzialy>();

    public virtual ICollection<PracEtaty> PracEtaties { get; set; } = new List<PracEtaty>();

    public virtual ICollection<ZestawyRegulElem> ZestawyRegulElems { get; set; } = new List<ZestawyRegulElem>();
}
