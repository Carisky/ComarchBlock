using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TwrCenyZakView
{
    public int TwCzvTwCnumer { get; set; }

    public int TwCzvTwrId { get; set; }

    public decimal TwCzvWartosc { get; set; }

    public string TwCzvWaluta { get; set; } = null!;
}
