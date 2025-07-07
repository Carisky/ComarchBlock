using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class PodpisCertyfikat
{
    public int PcePceId { get; set; }

    public int PceOpeId { get; set; }

    public int PceObjId { get; set; }

    public string PceOdciskPalca { get; set; } = null!;

    public string PceNazwa { get; set; } = null!;

    public int PcePytanie { get; set; }
}
