using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class TytUmowy
{
    public int TumTumId { get; set; }

    public string TumNazwa { get; set; } = null!;

    public string? TumImportRowId { get; set; }
}
