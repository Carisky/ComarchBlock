using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class FaCyklTwrKnt
{
    public int FctFcTid { get; set; }

    public int FctFcEid { get; set; }

    public int FctFcKid { get; set; }

    public byte FctTypKnt { get; set; }

    public int FctKntLp { get; set; }

    public decimal FctIlosc { get; set; }

    public string? FctJm { get; set; }

    public byte? FctTypNb { get; set; }

    public byte FctCenaZczteremaMiejscami { get; set; }

    public decimal FctCena { get; set; }

    public decimal? FctCenaBrutto { get; set; }

    public decimal FctCenaNettoPln { get; set; }

    public decimal FctCenaBruttoPln { get; set; }

    public string FctWaluta { get; set; } = null!;

    public string? FctNabywcaKod { get; set; }

    public string? FctNabywcaNazwa { get; set; }

    public string? FctOdbiorcaKod { get; set; }

    public string? FctOdbiorcaNazwa { get; set; }

    public string? FctObowiazujeOdTxt { get; set; }

    public string? FctObowiazujeDoTxt { get; set; }

    public virtual FaCyklElem FctFcE { get; set; } = null!;
}
