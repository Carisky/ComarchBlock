using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class NotyOdsElem
{
    public int NoeNoeid { get; set; }

    public int NoeNonid { get; set; }

    public int? NoeBzdId { get; set; }

    public int? NoeBrkid { get; set; }

    public string NoeNumer { get; set; } = null!;

    public string NoeOpis { get; set; } = null!;

    public DateTime NoeDataDok { get; set; }

    public DateTime NoeDataOd { get; set; }

    public DateTime NoeDataDo { get; set; }

    public decimal NoePodstawa { get; set; }

    public decimal NoeOdsetkiStopa { get; set; }

    public decimal NoeOdsetkiKwota { get; set; }

    public virtual BnkRozKwoty? NoeBrk { get; set; }

    public virtual BnkZdarzenium? NoeBzd { get; set; }

    public virtual NotyOdsNag NoeNon { get; set; } = null!;
}
