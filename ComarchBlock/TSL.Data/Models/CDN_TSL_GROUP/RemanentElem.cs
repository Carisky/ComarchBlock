using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class RemanentElem
{
    public int ReEReEid { get; set; }

    public int ReEReNid { get; set; }

    public int ReELp { get; set; }

    public int? ReETwrId { get; set; }

    public string ReENazwa { get; set; } = null!;

    public string ReEJm { get; set; } = null!;

    public byte ReEMetodaOblicz { get; set; }

    public decimal ReEIlosc { get; set; }

    public decimal ReECena { get; set; }

    public decimal ReEWartosc { get; set; }

    public decimal ReECenaNabycia { get; set; }

    public string ReEOpis { get; set; } = null!;

    public int? ReEOpeZalId { get; set; }

    public int? ReEStaZalId { get; set; }

    public DateTime ReETsZal { get; set; }

    public int? ReEOpeModId { get; set; }

    public int? ReEStaModId { get; set; }

    public DateTime ReETsMod { get; set; }

    public string ReEOpeModKod { get; set; } = null!;

    public string ReEOpeModNazwisko { get; set; } = null!;

    public string ReEOpeZalKod { get; set; } = null!;

    public string ReEOpeZalNazwisko { get; set; } = null!;

    public byte ReECenaZczteremaMiejscami { get; set; }

    public virtual RemanentNag ReEReN { get; set; } = null!;

    public virtual Towary? ReETwr { get; set; }
}
