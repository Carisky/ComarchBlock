using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class CfgTowarAutonumerSerie
{
    public int CtasCtasid { get; set; }

    public string CtasNazwa { get; set; } = null!;

    public string CtasOpis { get; set; } = null!;

    public byte CtasDomyslna { get; set; }
}
