using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdRekomendacjeWzorceWarunkiTwr
{
    public int PrewtId { get; set; }

    public int? PrewtPrewid { get; set; }

    public byte? PrewtTyp { get; set; }

    public short? PrewtTwrtyp { get; set; }

    public int? PrewtTwrnumer { get; set; }

    public virtual ProdRekomendacjeWzorce? PrewtPrew { get; set; }

    public virtual ICollection<ProdRekomendacjeWzorceWarunki> ProdRekomendacjeWzorceWarunkis { get; set; } = new List<ProdRekomendacjeWzorceWarunki>();
}
