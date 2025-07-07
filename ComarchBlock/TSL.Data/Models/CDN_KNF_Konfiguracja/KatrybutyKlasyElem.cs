using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class KatrybutyKlasyElem
{
    public int KaeKaeid { get; set; }

    public int KaeKakid { get; set; }

    public string KaeWartosc { get; set; } = null!;

    public virtual KatrybutyKlasy KaeKak { get; set; } = null!;
}
