using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class BazZakazy
{
    public int BzaBzaId { get; set; }

    public int? BzaOpeId { get; set; }

    public int? BzaBazId { get; set; }

    public virtual Operatorzy? BzaOpe { get; set; }
}
