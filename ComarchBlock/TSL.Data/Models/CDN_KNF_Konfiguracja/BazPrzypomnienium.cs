using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class BazPrzypomnienium
{
    public int BprBprId { get; set; }

    public int? BprOpeId { get; set; }

    public int? BprBazId { get; set; }

    public virtual Bazy? BprBaz { get; set; }

    public virtual Operatorzy? BprOpe { get; set; }
}
