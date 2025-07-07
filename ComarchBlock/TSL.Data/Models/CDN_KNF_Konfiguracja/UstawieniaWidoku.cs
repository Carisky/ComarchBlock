using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class UstawieniaWidoku
{
    public int UwiUwiId { get; set; }

    public int UwiWidok { get; set; }

    public int? UwiOperator { get; set; }

    public int? UwiX { get; set; }

    public int? UwiY { get; set; }

    public int? UwiSzerokosc { get; set; }

    public int? UwiWysokosc { get; set; }

    public bool? UwiCzyZmaksymalizowany { get; set; }

    public virtual ICollection<UstawieniaWidokuSzczegoly> UstawieniaWidokuSzczegolies { get; set; } = new List<UstawieniaWidokuSzczegoly>();
}
