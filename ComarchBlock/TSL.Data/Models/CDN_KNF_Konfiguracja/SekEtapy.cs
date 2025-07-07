using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class SekEtapy
{
    public int SeSeid { get; set; }

    public string SeSymbol { get; set; } = null!;

    public string SeNazwa { get; set; } = null!;

    public byte SeCzyKomentarzNieobowiazkowy { get; set; }

    public byte SeCzyDomyslnyCzasRealizacji { get; set; }

    public int? SeDomyslnyCzasRealizacji { get; set; }

    public virtual ICollection<SekEtapOperatorzy> SekEtapOperatorzies { get; set; } = new List<SekEtapOperatorzy>();

    public virtual ICollection<SekSchemEtapy> SekSchemEtapies { get; set; } = new List<SekSchemEtapy>();
}
