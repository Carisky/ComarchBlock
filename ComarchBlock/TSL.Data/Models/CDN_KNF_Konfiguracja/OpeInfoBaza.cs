using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class OpeInfoBaza
{
    public int OibOibid { get; set; }

    public int OibOpeId { get; set; }

    public int OibBazId { get; set; }

    public DateTime? OibData { get; set; }

    public virtual Bazy OibBaz { get; set; } = null!;

    public virtual Operatorzy OibOpe { get; set; } = null!;
}
