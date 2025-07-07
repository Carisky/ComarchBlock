using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ObiektyZablok
{
    public short ObZGidtyp { get; set; }

    public int? ObZGidfirma { get; set; }

    public int ObZGidnumer { get; set; }

    public short ObZGidlp { get; set; }

    public int ObZSesjaId { get; set; }

    public int? ObZDataCzasZalozenia { get; set; }

    public string? ObZNazwaFunkcji { get; set; }
}
