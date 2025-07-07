using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class KadrSlowniki
{
    public int KslId { get; set; }

    public int? KslTyp { get; set; }

    public int? KslPredefiniowany { get; set; }

    public string? KslKod { get; set; }

    public string? KslNazwa { get; set; }

    public string? KslOpis { get; set; }

    public byte? KslArchiwalny { get; set; }

    public string? KslSymbol { get; set; }

    public int? KslFlaga1 { get; set; }

    public int? KslFlaga2 { get; set; }

    public int? KslFlaga3 { get; set; }

    public decimal? KslWartoscN1 { get; set; }

    public decimal? KslWartoscN2 { get; set; }

    public string? KslWartoscS1 { get; set; }

    public int? KslData { get; set; }

    public int? KslOpeWnumer { get; set; }

    public int? KslCzasWprowadzenia { get; set; }

    public int? KslOpeMnumer { get; set; }

    public int? KslCzasModyfikacji { get; set; }
}
