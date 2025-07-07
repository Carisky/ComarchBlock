using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PrmHistorium
{
    public int PrHId { get; set; }

    public short? PrHGidtyp { get; set; }

    public int? PrHGidfirma { get; set; }

    public int? PrHGidnumer { get; set; }

    public short? PrHGidlp { get; set; }

    public int? PrHIdprm { get; set; }

    public decimal? PrHRabatKwota { get; set; }

    public int? PrHRodzajRabatu { get; set; }

    public decimal? PrHRabatProcent { get; set; }

    public decimal? PrHRabatKwotaDokl { get; set; }

    public decimal? PrHRabatEfektywny { get; set; }

    public int PrHBudzetId { get; set; }

    public int? PrHTprid { get; set; }
}
