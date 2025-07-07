using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class BnkDokElem
{
    public int BdeBdeid { get; set; }

    public int BdeBdnid { get; set; }

    public string BdeDokTyp { get; set; } = null!;

    public int? BdeDokId { get; set; }

    public string BdeNumer { get; set; } = null!;

    public string BdeOpis { get; set; } = null!;

    public DateTime BdeDataDok { get; set; }

    public DateTime BdeTermin { get; set; }

    public decimal BdeKwota1 { get; set; }

    public decimal BdeKwota2 { get; set; }

    public decimal BdeKwota { get; set; }

    public virtual BnkDokNag BdeBdn { get; set; } = null!;
}
