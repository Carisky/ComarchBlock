using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TwrGrupyView
{
    public int? TwGid { get; set; }

    public string? Sciezka { get; set; }

    public string? Kod { get; set; }

    public string? Nazwa { get; set; }

    public int Poziom { get; set; }

    public int Gidnumer { get; set; }

    public int GrOnumer { get; set; }
}
