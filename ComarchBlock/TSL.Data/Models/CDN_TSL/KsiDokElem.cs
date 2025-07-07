using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class KsiDokElem
{
    public int KdeKdeid { get; set; }

    public int KdeKdnid { get; set; }

    public int? KdeLp { get; set; }

    public string KdeNumer { get; set; } = null!;

    public string KdeOpis { get; set; } = null!;

    public DateTime KdeDataWys { get; set; }

    public DateTime KdeTermin { get; set; }

    public decimal KdeKwota1 { get; set; }

    public decimal KdeKwota2 { get; set; }

    public decimal? KdeKwota3 { get; set; }

    public decimal KdeKwota { get; set; }

    public DateTime? KdeDataOd { get; set; }

    public DateTime? KdeDataDo { get; set; }

    public int? KdeBoeid { get; set; }

    public int? KdeDeEid { get; set; }

    public int? KdeKroId { get; set; }

    public virtual KsiDokNag KdeKdn { get; set; } = null!;
}
