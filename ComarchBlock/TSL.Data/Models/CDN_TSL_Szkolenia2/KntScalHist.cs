using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class KntScalHist
{
    public int KshKshid { get; set; }

    public string? KshNazwaTabeli { get; set; }

    public int? KshIdwiersza { get; set; }

    public string? KshNumerDok { get; set; }

    public int? KshOldKntId { get; set; }

    public string? KshOldKntKod { get; set; }

    public int? KshNewKntId { get; set; }

    public string? KshNewKntKod { get; set; }
}
