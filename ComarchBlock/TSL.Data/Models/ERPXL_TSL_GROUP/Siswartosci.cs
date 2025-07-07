using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Siswartosci
{
    public short? SiwGidtyp { get; set; }

    public int? SiwGidfirma { get; set; }

    public int SiwGidnumer { get; set; }

    public short SiwGidlp { get; set; }

    public int? SiwDataOd { get; set; }

    public int? SiwDataDo { get; set; }

    public int? SiwTsobliczenia { get; set; }

    public string? SiwWartosc { get; set; }

    public virtual Sisdefinicje SiwGidnumerNavigation { get; set; } = null!;
}
