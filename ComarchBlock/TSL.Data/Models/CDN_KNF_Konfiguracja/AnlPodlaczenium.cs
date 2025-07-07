using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class AnlPodlaczenium
{
    public int AnPProcId { get; set; }

    public int AnPKontId { get; set; }

    public byte AnPStandardowa { get; set; }

    public int AnPNadAnlId { get; set; }

    public int AnPAnlId { get; set; }

    public string? AnPWarunek { get; set; }

    public int? AnPLp { get; set; }

    public byte? AnPDomyslna { get; set; }

    public string? AnPEdycja { get; set; }
}
