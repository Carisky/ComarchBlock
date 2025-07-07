using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class TmpGeography
{
    public string GeoOrgId { get; set; } = null!;

    public int GeoId { get; set; }

    public string? GeoKrajKod { get; set; }

    public int? GeoId2 { get; set; }

    public string? GeoOrgId2 { get; set; }
}
