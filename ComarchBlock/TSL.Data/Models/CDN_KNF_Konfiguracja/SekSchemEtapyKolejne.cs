using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class SekSchemEtapyKolejne
{
    public int SsekSsekid { get; set; }

    public int? SsekSseid { get; set; }

    public int? SsekSseidkolejny { get; set; }

    public virtual SekSchemEtapy? SsekSse { get; set; }
}
