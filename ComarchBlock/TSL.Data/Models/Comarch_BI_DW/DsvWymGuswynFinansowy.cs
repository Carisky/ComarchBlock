using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymGuswynFinansowy
{
    public int GuswynId { get; set; }

    public string GuswynNazwa { get; set; } = null!;

    public string? GuswynOpis { get; set; }

    public int? GuswynRowId { get; set; }
}
