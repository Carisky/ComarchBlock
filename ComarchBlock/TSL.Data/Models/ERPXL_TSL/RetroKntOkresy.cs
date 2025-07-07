using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class RetroKntOkresy
{
    public int RkoId { get; set; }

    public int? RkoRtKid { get; set; }

    public string? RkoNazwa { get; set; }

    public short? RkoKntTyp { get; set; }

    public int? RkoKntFirma { get; set; }

    public int? RkoKntNumer { get; set; }

    public short? RkoKntLp { get; set; }

    public int? RkoDataOd { get; set; }

    public int? RkoDataDo { get; set; }

    public decimal? RkoWartoscUzgodniona { get; set; }

    public byte? RkoStan { get; set; }

    public string? RkoOpis { get; set; }

    public int? RkoAktywny { get; set; }

    public virtual RetroKontrahenci? RetroKontrahenci { get; set; }

    public virtual ICollection<RetroStrukturaRabatu> RetroStrukturaRabatus { get; set; } = new List<RetroStrukturaRabatu>();
}
