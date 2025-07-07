using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class SekSchematy
{
    public int SsSsid { get; set; }

    public string SsKod { get; set; } = null!;

    public string SsNazwa { get; set; } = null!;

    public short SsNieaktywny { get; set; }

    public virtual ICollection<SekSchemEtapy> SekSchemEtapies { get; set; } = new List<SekSchemEtapy>();
}
