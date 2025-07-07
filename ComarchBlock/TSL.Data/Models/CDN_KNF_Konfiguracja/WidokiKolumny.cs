using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class WidokiKolumny
{
    public int WiCWiCid { get; set; }

    public int WiCKakid { get; set; }

    public int WiCWiNid { get; set; }

    public short WiCLp { get; set; }

    public int WiCGrupowanie { get; set; }

    public int WiCSzerokosc { get; set; }

    public virtual KatrybutyKlasy WiCKak { get; set; } = null!;

    public virtual WidokiNazwy WiCWiN { get; set; } = null!;
}
