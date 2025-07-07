using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DeklElem
{
    public int DkEDkEid { get; set; }

    public int DkEDkNid { get; set; }

    public int DkENumer { get; set; }

    public decimal DkEWartoscL { get; set; }

    public decimal DkEWartoscM { get; set; }

    public string DkEWartoscTekst { get; set; } = null!;

    public string DkEOpis { get; set; } = null!;

    public virtual DeklNag DkEDkN { get; set; } = null!;
}
