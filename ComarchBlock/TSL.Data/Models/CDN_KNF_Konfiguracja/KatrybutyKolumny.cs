using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class KatrybutyKolumny
{
    public int KacKacid { get; set; }

    public int KacKakid { get; set; }

    public int KacOpeId { get; set; }

    public short KacLp { get; set; }

    public int KacGrupowanie { get; set; }

    public int KacSzerokosc { get; set; }

    public virtual KatrybutyKlasy KacKak { get; set; } = null!;

    public virtual Operatorzy KacOpe { get; set; } = null!;
}
