using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class ZasobyJezykowe
{
    public string ZjeId { get; set; } = null!;

    public int ZjeJezyk { get; set; }

    public string ZjeKomunikat { get; set; } = null!;
}
