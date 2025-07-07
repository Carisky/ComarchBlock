using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class AwizoOpakowanium
{
    public int AwoAwoid { get; set; }

    public int AwoAwzid { get; set; }

    public int AwoOpakowanieId { get; set; }

    public int AwoParentId { get; set; }

    public string AwoOpis { get; set; } = null!;

    public string AwoNrZamowienia { get; set; } = null!;

    public string AwoNrOdbiorca { get; set; } = null!;

    public int AwoTrEid { get; set; }

    public string AwoKodSscc { get; set; } = null!;

    public int AwoTwrId { get; set; }

    public decimal AwoTwrIlosc { get; set; }

    public decimal AwoObjetosc { get; set; }

    public decimal AwoWaga { get; set; }

    public int AwoTypOpakowaniaId { get; set; }

    public virtual Awizo AwoAwz { get; set; } = null!;
}
