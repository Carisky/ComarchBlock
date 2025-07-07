using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ZestKskolumny
{
    public short? ZkkGidtyp { get; set; }

    public int? ZkkGidfirma { get; set; }

    public int ZkkGidnumer { get; set; }

    public short ZkkGidlp { get; set; }

    public string? ZkkTytul { get; set; }

    public string? ZkkFormat { get; set; }

    public string? ZkkWyrazenie { get; set; }

    public virtual ZestKswidok ZkkGidnumerNavigation { get; set; } = null!;
}
