using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class EteczkiCertyfikaty
{
    public int EtcEtcId { get; set; }

    public int EtcOpeId { get; set; }

    public string EtcNazwa { get; set; } = null!;

    public string EtcThumbprint { get; set; } = null!;

    public int EtcPodpis { get; set; }
}
