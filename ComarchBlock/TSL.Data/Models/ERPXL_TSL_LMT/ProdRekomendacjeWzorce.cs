using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdRekomendacjeWzorce
{
    public int PrewId { get; set; }

    public string? PrewKod { get; set; }

    public string? PrewNazwa { get; set; }

    public short? PrewRodzaj { get; set; }

    public byte? PrewDomyslny { get; set; }

    public string? PrewOpis { get; set; }

    public byte? PrewArchiwalny { get; set; }

    public int? PrewOpeWnumer { get; set; }

    public int? PrewOpeMnumer { get; set; }

    public int? PrewDataCzasW { get; set; }

    public int? PrewDataCzasM { get; set; }

    public virtual OpeKarty? PrewOpeWnumerNavigation { get; set; }

    public virtual ICollection<ProdRekomendacjeWzorceWarunkiTwr> ProdRekomendacjeWzorceWarunkiTwrs { get; set; } = new List<ProdRekomendacjeWzorceWarunkiTwr>();
}
