using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class MailPodpisy
{
    public int MpdMpdid { get; set; }

    public int? MpdOpeId { get; set; }

    public string MpdNazwa { get; set; } = null!;

    public string MpdPodpis { get; set; } = null!;

    public byte? MpdDomyslny { get; set; }
}
