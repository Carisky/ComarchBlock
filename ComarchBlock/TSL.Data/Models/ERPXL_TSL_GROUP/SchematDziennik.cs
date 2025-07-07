using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SchematDziennik
{
    public short ScdGidtyp { get; set; }

    public int? ScdGidfirma { get; set; }

    public int ScdGidnumer { get; set; }

    public short ScdGidlp { get; set; }

    public short? ScdLp { get; set; }

    public string? ScdDziennik { get; set; }

    public string? ScdWarunek { get; set; }

    public string? ScdWarunekSymb { get; set; }

    public virtual Schematy Schematy { get; set; } = null!;
}
