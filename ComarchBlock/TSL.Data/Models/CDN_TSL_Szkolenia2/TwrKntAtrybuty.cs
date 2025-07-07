using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TwrKntAtrybuty
{
    public int TkaTkaid { get; set; }

    public int? TkaTwAid { get; set; }

    public short? TkaPodmiotTyp { get; set; }

    public int? TkaPodmiotId { get; set; }

    public string TkaWartoscTxt { get; set; } = null!;

    public virtual PodmiotyView? PodmiotyView { get; set; }

    public virtual TwrAtrybuty? TkaTwA { get; set; }
}
