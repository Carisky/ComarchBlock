using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class TestyDefiniowane
{
    public int TdeId { get; set; }

    public string? TdeNazwa { get; set; }

    public string? TdeZapytanie { get; set; }

    public byte? TdeZdarzenie { get; set; }

    public byte? TdeAktywny { get; set; }
}
