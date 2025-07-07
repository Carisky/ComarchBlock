using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class OpisKadry
{
    public int OpkOpkId { get; set; }

    public int OpkRodzajZrodla { get; set; }

    public int OpkZrodloId { get; set; }

    public int? OpkPraId { get; set; }

    public int OpkDzlId { get; set; }

    public int OpkPrjId { get; set; }

    public decimal OpkProcent { get; set; }

    public virtual Dzialy OpkDzl { get; set; } = null!;

    public virtual PracKod? OpkPra { get; set; }
}
