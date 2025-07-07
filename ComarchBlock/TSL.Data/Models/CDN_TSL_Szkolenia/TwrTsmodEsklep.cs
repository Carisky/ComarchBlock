using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TwrTsmodEsklep
{
    public int TwTsTwrId { get; set; }

    public DateTime TwTsTsModEsklep { get; set; }

    public virtual Towary TwTsTwr { get; set; } = null!;
}
