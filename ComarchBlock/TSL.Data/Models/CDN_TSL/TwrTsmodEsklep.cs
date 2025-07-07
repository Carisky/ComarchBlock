using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TwrTsmodEsklep
{
    public int TwTsTwrId { get; set; }

    public DateTime TwTsTsModEsklep { get; set; }

    public virtual Towary TwTsTwr { get; set; } = null!;
}
