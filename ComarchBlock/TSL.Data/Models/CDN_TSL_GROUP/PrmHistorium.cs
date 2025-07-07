using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class PrmHistorium
{
    public string? PrHId { get; set; }

    public short PrHGidtyp { get; set; }

    public int? PrHGidfirma { get; set; }

    public int PrHGidnumer { get; set; }

    public short PrHGidlp { get; set; }

    public int PrHIdprm { get; set; }

    public decimal? PrHRabatKwota { get; set; }

    public short? PrHRodzajRabatu { get; set; }

    public decimal? PrHRabatProcent { get; set; }

    public decimal? PrHRabatKwotaDokl { get; set; }

    public decimal? PrHRabatEfektywny { get; set; }

    public int PrHTrEid { get; set; }

    public virtual TraElem PrHTrE { get; set; } = null!;
}
