using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class AwizoTowary
{
    public int AwtAwtid { get; set; }

    public int AwtAwzid { get; set; }

    public string AwtNrZamowienia { get; set; } = null!;

    public DateTime AwtDataZamowienia { get; set; }

    public string AwtNrOdbiorca { get; set; } = null!;

    public int AwtTrEid { get; set; }

    public int AwtTwrId { get; set; }

    public string AwtTwrKod { get; set; } = null!;

    public string AwtTwrNazwa { get; set; } = null!;

    public string AwtTwrEan { get; set; } = null!;

    public decimal AwtIloscDoSpakuj { get; set; }

    public decimal AwtIloscZapakowana { get; set; }

    public decimal AwtIloscCalkowita { get; set; }

    public string AwtJm { get; set; } = null!;

    public string AwtNrRo { get; set; } = null!;

    public virtual Awizo AwtAwz { get; set; } = null!;
}
