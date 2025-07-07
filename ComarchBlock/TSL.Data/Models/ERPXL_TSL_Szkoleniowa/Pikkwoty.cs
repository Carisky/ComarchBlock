using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Pikkwoty
{
    public short? PikGidtyp { get; set; }

    public int? PikGidfirma { get; set; }

    public int PikGidnumer { get; set; }

    public short PikGidlp { get; set; }

    public short PikRodzaj { get; set; }

    public short PikSymbol { get; set; }

    public int PikPodRodzajId { get; set; }

    public short? PikKosztFirma { get; set; }

    public int? PikUbztyuId { get; set; }

    public decimal? PikKwota { get; set; }

    public byte PikTypWyplaty { get; set; }

    public decimal? PikKwotaUjemna { get; set; }

    public virtual Pikelem Pikelem { get; set; } = null!;
}
