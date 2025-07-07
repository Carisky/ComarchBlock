using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TwrOcrmapowanie
{
    public int TwOmTwrId { get; set; }

    public string TwOmTwrOcrnazwa { get; set; } = null!;

    public virtual Towary TwOmTwr { get; set; } = null!;
}
