using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Uwdkonfig
{
    public int UknUknId { get; set; }

    public int UknBazId { get; set; }

    public int UknTypWymiany { get; set; }

    public int UknPartnerId { get; set; }

    public string UknOddzialId { get; set; } = null!;

    public int UknSoaSync { get; set; }

    public short? UknAplikacja { get; set; }

    public virtual Bazy UknBaz { get; set; } = null!;
}
