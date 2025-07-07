using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DokumentyDostawyElem
{
    public int DdeDdeid { get; set; }

    public int DdeDdnid { get; set; }

    public int DdeLp { get; set; }

    public string DdeKodCn { get; set; } = null!;

    public decimal DdeIlosc { get; set; }

    public string DdeJm { get; set; } = null!;

    public decimal DdeMasaNetto { get; set; }

    public decimal DdeMasaBrutto { get; set; }

    public string? DdeOpis { get; set; }

    public virtual DokumentyDostawyNag DdeDdn { get; set; } = null!;
}
