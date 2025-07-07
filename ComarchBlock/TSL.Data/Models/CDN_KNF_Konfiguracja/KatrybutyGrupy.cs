using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class KatrybutyGrupy
{
    public int KagKagid { get; set; }

    public string KagNazwa { get; set; } = null!;

    public virtual ICollection<KatrybutyKlasy> KatrybutyKlasies { get; set; } = new List<KatrybutyKlasy>();
}
