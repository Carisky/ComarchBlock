using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PlanyElementyProdukty
{
    public int PgpId { get; set; }

    public int? PgpPgsid { get; set; }

    public short? PgpObiTyp { get; set; }

    public int? PgpObiNumer { get; set; }

    public decimal? PgpIlosc { get; set; }

    public string? PgpJm { get; set; }

    public virtual PlanyElementySkladnikow? PgpPgs { get; set; }
}
