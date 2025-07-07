using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TwrPrzeceny
{
    public int TpcTwrId { get; set; }

    public int TpcTwCnumer { get; set; }

    public DateTime TpcData { get; set; }

    public decimal TpcWartosc { get; set; }

    public string TpcWaluta { get; set; } = null!;

    public virtual Towary TpcTwr { get; set; } = null!;
}
