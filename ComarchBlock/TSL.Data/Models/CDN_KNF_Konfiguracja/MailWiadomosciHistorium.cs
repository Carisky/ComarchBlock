using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class MailWiadomosciHistorium
{
    public int MwhMwhid { get; set; }

    public int MwhMwdid { get; set; }

    public string MwhAkcja { get; set; } = null!;

    public string? MwhKomentarz { get; set; }

    public string? MwhOperatorWykonujacy { get; set; }

    public DateTime? MwhData { get; set; }

    public virtual MailWiadomosci MwhMwd { get; set; } = null!;
}
