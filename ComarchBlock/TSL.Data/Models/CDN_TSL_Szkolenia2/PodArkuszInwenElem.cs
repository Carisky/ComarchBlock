using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PodArkuszInwenElem
{
    public int PaePaeid { get; set; }

    public int PaePaiid { get; set; }

    public int PaeLp { get; set; }

    public int PaeTrEid { get; set; }

    public int? PaeTwrId { get; set; }

    public string PaeTwrKod { get; set; } = null!;

    public string PaeTwrNazwa { get; set; } = null!;

    public string PaeTwrEan { get; set; } = null!;

    public decimal PaeIlosc { get; set; }

    public string PaeJm { get; set; } = null!;

    public string PaeJmz { get; set; } = null!;

    public virtual PodArkuszInwenNag PaePai { get; set; } = null!;

    public virtual Towary? PaeTwr { get; set; }
}
