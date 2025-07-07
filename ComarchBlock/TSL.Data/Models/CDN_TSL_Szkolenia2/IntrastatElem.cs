using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class IntrastatElem
{
    public int IsEIsEid { get; set; }

    public int? IsEIsNid { get; set; }

    public int IsELp { get; set; }

    public string IsEKraj { get; set; } = null!;

    public string IsEOpis { get; set; } = null!;

    public string IsERodzajTransakcji { get; set; } = null!;

    public string IsECn { get; set; } = null!;

    public string IsEKrajPochodzenia { get; set; } = null!;

    public decimal IsEMasaNetto { get; set; }

    public decimal IsEJmUzup { get; set; }

    public decimal IsENetto { get; set; }

    public byte IsEAutomatyczny { get; set; }

    public string IsENumerIdentKnt { get; set; } = null!;

    public virtual IntrastatNag? IsEIsN { get; set; }
}
