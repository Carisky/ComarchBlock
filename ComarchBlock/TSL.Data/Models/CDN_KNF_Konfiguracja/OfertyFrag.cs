using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class OfertyFrag
{
    public int OfeOfeId { get; set; }

    public string? OfeTyp { get; set; }

    public string OfeNazwa { get; set; } = null!;

    public string? OfeBody { get; set; }

    public string? OfeText { get; set; }
}
