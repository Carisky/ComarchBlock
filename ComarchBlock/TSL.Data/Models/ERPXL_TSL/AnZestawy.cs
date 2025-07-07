using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class AnZestawy
{
    public short? AnZGidtyp { get; set; }

    public int? AnZGidfirma { get; set; }

    public int AnZGidnumer { get; set; }

    public short? AnZGidlp { get; set; }

    public short? AnZAnFtyp { get; set; }

    public int? AnZAnFfirma { get; set; }

    public int? AnZAnFnumer { get; set; }

    public short? AnZAnFlp { get; set; }

    public int? AnZTstart { get; set; }

    public int? AnZTstop { get; set; }

    public int? AnZDataOd { get; set; }

    public int? AnZDataDo { get; set; }

    public int? AnZStan { get; set; }

    public string? AnZOpis { get; set; }

    public virtual AnFunkcje? AnFunkcje { get; set; }

    public virtual ICollection<AnWyniki> AnWynikis { get; set; } = new List<AnWyniki>();
}
