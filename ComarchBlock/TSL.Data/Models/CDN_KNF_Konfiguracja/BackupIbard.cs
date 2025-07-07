using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class BackupIbard
{
    public int BibBibid { get; set; }

    public string BibSerwer { get; set; } = null!;

    public string BibConnectionString { get; set; } = null!;

    public byte[]? BibToken { get; set; }
}
