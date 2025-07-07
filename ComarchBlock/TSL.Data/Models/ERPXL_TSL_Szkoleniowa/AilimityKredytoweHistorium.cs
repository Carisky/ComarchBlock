using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class AilimityKredytoweHistorium
{
    public int AilkhId { get; set; }

    public int? AilkhKntNumer { get; set; }

    public decimal? AilkhWartoscAi { get; set; }

    public decimal? AilkhWartoscXl { get; set; }

    public int? AilkhDataDodania { get; set; }

    public virtual KntKarty? AilkhKntNumerNavigation { get; set; }
}
