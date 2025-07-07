using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class RetroStrukturaRabatu
{
    public int RsrId { get; set; }

    public int? RsrRkoid { get; set; }

    public short? RsrGidtyp { get; set; }

    public int? RsrGidfirma { get; set; }

    public int? RsrGidnumer { get; set; }

    public short? RsrGidlp { get; set; }

    public decimal? RsrIlosc { get; set; }

    public decimal? RsrRabatPodstawa { get; set; }

    public decimal? RsrRabatWartosc { get; set; }

    public decimal? RsrCena { get; set; }

    public virtual RetroKntOkresy? RsrRko { get; set; }

    public virtual TraElem? TraElem { get; set; }
}
