using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class WidokiNazwy
{
    public int WiNWiNid { get; set; }

    public byte WiNSystemowy { get; set; }

    public string? WiNNazwa { get; set; }

    public virtual ICollection<WidokiKolumny> WidokiKolumnies { get; set; } = new List<WidokiKolumny>();
}
