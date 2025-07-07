using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class UstawieniaWidokuSzczegoly
{
    public int UwsUwsId { get; set; }

    public int UwsUwiId { get; set; }

    public string UwsNazwa { get; set; } = null!;

    public string? UwsWartosc { get; set; }

    public virtual UstawieniaWidoku UwsUwi { get; set; } = null!;
}
