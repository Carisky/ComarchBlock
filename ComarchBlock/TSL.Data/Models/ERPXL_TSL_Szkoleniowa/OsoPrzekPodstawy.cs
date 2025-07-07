using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class OsoPrzekPodstawy
{
    public int OppId { get; set; }

    public int? OppOsoNumer { get; set; }

    public byte? OppInfoPrzekazana { get; set; }

    public decimal? OppKwota { get; set; }

    public byte? OppInterpretacja { get; set; }

    public int? OppRokMiesiac { get; set; }

    public int? OppOpeWnumer { get; set; }

    public int? OppCzasWprowadzenia { get; set; }

    public int? OppOpeMnumer { get; set; }

    public int? OppCzasModyfikacji { get; set; }

    public virtual PrcKarty? OppOsoNumerNavigation { get; set; }
}
