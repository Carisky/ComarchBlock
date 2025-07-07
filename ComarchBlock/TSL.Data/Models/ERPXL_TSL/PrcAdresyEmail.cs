using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class PrcAdresyEmail
{
    public int PraeId { get; set; }

    public int? PraePrcNumer { get; set; }

    public string? PraeAdresEmail { get; set; }

    public byte? PraeCzyLoginBi { get; set; }

    public byte? PraeDomyslny { get; set; }

    public virtual PrcKarty? PraePrcNumerNavigation { get; set; }
}
