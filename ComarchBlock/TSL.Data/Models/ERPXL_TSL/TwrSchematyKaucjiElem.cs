using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class TwrSchematyKaucjiElem
{
    public int SkeSknid { get; set; }

    public int SkeLp { get; set; }

    public int? SkeTwrNumer { get; set; }

    public decimal? SkeProg { get; set; }

    public decimal? SkeIlosc { get; set; }

    public virtual TwrSchematyKaucjiNag SkeSkn { get; set; } = null!;

    public virtual TwrKarty? SkeTwrNumerNavigation { get; set; }
}
