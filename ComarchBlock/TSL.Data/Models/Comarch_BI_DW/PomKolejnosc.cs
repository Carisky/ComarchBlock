using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class PomKolejnosc
{
    public int KolId { get; set; }

    public string? KolParOrgId { get; set; }

    public int? KolIndeks { get; set; }
}
