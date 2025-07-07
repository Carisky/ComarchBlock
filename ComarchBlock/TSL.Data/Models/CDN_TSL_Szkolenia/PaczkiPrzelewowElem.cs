using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class PaczkiPrzelewowElem
{
    public int PcPePcPeid { get; set; }

    public int PcPePcPnid { get; set; }

    public int PcPeBzdId { get; set; }

    public string? PcPeNumerOpis { get; set; }

    public DateTime? PcPeDataDok { get; set; }

    public DateTime? PcPeTermin { get; set; }

    public DateTime? PcPeDataReal { get; set; }

    public decimal? PcPeKwota { get; set; }

    public string? PcPeSymbolWaluty { get; set; }

    public string? PcPePodmiotKod { get; set; }

    public string? PcPeCdckomunikat { get; set; }

    public virtual PaczkiPrzelewowNag PcPePcPn { get; set; } = null!;
}
