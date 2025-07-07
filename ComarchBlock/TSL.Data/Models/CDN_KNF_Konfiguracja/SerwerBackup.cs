using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class SerwerBackup
{
    public int SbcSbcId { get; set; }

    public string SbcSerwer { get; set; } = null!;

    public string SbcUzytkownik { get; set; } = null!;

    public byte[] SbcHaslo { get; set; } = null!;

    public int SbcNt { get; set; }
}
