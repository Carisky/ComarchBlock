using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class WebViewSetting
{
    public int VseVseId { get; set; }

    public int? VseOpeId { get; set; }

    public string VseKey { get; set; } = null!;

    public string? VseSettings { get; set; }
}
