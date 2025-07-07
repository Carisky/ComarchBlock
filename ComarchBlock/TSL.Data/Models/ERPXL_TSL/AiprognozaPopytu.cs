using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class AiprognozaPopytu
{
    public int AippId { get; set; }

    public int? AippTwrNumer { get; set; }

    public int? AippDataPrognozy { get; set; }

    public int? AippMagNumer { get; set; }

    public decimal? AippIlosc { get; set; }

    public virtual Magazyny? AippMagNumerNavigation { get; set; }

    public virtual TwrKarty? AippTwrNumerNavigation { get; set; }
}
