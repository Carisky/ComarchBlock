using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class MailWatek
{
    public int MwaMwaid { get; set; }

    public string MwaWatek { get; set; } = null!;

    public int MwaDomyslny { get; set; }
}
