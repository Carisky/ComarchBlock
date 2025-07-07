using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Eteczki
{
    public int EteEteId { get; set; }

    public string EteNazwa { get; set; } = null!;

    public int EteDomyslna { get; set; }
}
