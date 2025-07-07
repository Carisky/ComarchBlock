using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class AnkietyOkresy
{
    public int AnoId { get; set; }

    public string? AnoOpis { get; set; }

    public int? AnoPoczatek { get; set; }

    public int? AnoKoniec { get; set; }
}
