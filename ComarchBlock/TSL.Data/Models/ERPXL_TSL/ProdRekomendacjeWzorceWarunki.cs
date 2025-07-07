using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdRekomendacjeWzorceWarunki
{
    public int PrewwId { get; set; }

    public int? PrewwPrewtid { get; set; }

    public short? PrewwKolumnaPp { get; set; }

    public short? PrewwOperator { get; set; }

    public string? PrewwWartosc { get; set; }

    public virtual ProdRekomendacjeWzorceWarunkiTwr? PrewwPrewt { get; set; }
}
