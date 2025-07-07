using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class KatrybutyKlasyZakaz
{
    public int KazKazid { get; set; }

    public int KazKakid { get; set; }

    public int KazOpeId { get; set; }

    public byte KazPodglad { get; set; }

    public byte KazEdycja { get; set; }

    public virtual KatrybutyKlasy KazKak { get; set; } = null!;

    public virtual Operatorzy KazOpe { get; set; } = null!;
}
