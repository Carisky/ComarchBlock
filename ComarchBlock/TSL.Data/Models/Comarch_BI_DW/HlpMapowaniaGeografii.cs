using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class HlpMapowaniaGeografii
{
    public int GeoRowId { get; set; }

    public int GeoKod { get; set; }

    public string? GeoNazwa { get; set; }

    public string? GeoOrgId { get; set; }

    public int GeoTyp { get; set; }

    public string? GeoWojewodztwo { get; set; }
}
