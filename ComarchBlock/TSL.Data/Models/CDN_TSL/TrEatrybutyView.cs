using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TrEatrybutyView
{
    public int TraTreId { get; set; }

    public int TraDeAid { get; set; }

    public string TraKod { get; set; } = null!;

    public string TraWartosc { get; set; } = null!;

    public int? TreTwrId { get; set; }

    public int TreTrnId { get; set; }

    public string TreTwrKod { get; set; } = null!;

    public int TreLp { get; set; }

    public string TreJm { get; set; } = null!;

    public decimal TreIloscJm { get; set; }

    public string TreTwrNazwa { get; set; } = null!;

    public decimal TreWartoscNetto { get; set; }

    public decimal TreCenaT { get; set; }

    public DateTime TrEDataOpe { get; set; }

    public decimal? TrAWartoscDecimal { get; set; }
}
