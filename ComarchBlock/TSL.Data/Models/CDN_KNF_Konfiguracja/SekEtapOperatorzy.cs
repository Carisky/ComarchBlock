using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class SekEtapOperatorzy
{
    public int SeoSeoid { get; set; }

    public int? SeoSeid { get; set; }

    public int? SeoOpeId { get; set; }

    public virtual Operatorzy? SeoOpe { get; set; }

    public virtual SekEtapy? SeoSe { get; set; }
}
