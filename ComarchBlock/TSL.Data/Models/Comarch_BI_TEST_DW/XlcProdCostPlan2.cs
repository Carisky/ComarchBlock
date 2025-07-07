using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class XlcProdCostPlan2
{
    public int? ZlecenieId { get; set; }

    public int? ZlecenieLpId { get; set; }

    public int? TechnologiaId { get; set; }

    public int? ProcesId { get; set; }

    public int? CzynnoscId { get; set; }

    public int? TypKosztu { get; set; }

    public decimal? Wartosckosztu { get; set; }

    public decimal? Ilosc { get; set; }

    public decimal? IloscProcesow { get; set; }

    public decimal? IloscProcesowTech { get; set; }

    public string? Kod { get; set; }

    public string? Nazwa { get; set; }

    public int? CzynnoscPolproduktuId { get; set; }

    public int? ZasobId { get; set; }

    public int? TwrTyp { get; set; }

    public int? TwrGidnumer { get; set; }

    public int? Poziom { get; set; }

    public int? TypZasobu { get; set; }

    public int? IloscFormat { get; set; }
}
