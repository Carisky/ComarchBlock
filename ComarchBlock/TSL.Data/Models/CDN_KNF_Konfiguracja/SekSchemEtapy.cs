using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class SekSchemEtapy
{
    public int SseSseid { get; set; }

    public int? SseSsid { get; set; }

    public int? SseSeid { get; set; }

    public int SseLp { get; set; }

    public short SsePoziom { get; set; }

    public short SseObowiazkowy { get; set; }

    public virtual ICollection<SekSchemEtapyKolejne> SekSchemEtapyKolejnes { get; set; } = new List<SekSchemEtapyKolejne>();

    public virtual SekEtapy? SseSe { get; set; }

    public virtual SekSchematy? SseSs { get; set; }
}
