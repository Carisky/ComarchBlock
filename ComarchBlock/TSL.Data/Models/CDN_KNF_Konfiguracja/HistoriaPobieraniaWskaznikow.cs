using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class HistoriaPobieraniaWskaznikow
{
    public int HpwHpwid { get; set; }

    public DateTime HpwDataImportu { get; set; }

    public string HpwNazwa { get; set; } = null!;

    public string HpwWartosc { get; set; } = null!;

    public DateTime HpwObowiazujeOd { get; set; }
}
