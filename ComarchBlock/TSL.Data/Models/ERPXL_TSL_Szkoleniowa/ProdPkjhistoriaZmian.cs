using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdPkjhistoriaZmian
{
    public int PkjhId { get; set; }

    public short? PkjhObiTyp { get; set; }

    public int? PkjhObiNumer { get; set; }

    public byte? PkjhTypZmiany { get; set; }

    public int? PkjhCzasZmiany { get; set; }

    public string? PkjhOpeIdent { get; set; }

    public string? PkjhObiNazwa { get; set; }

    public string? PkjhKolumna { get; set; }

    public string? PkjhStaraWartosc { get; set; }

    public string? PkjhNowaWartosc { get; set; }

    public int? PkjhPkjid { get; set; }

    public virtual ProdPkjnag? PkjhPkj { get; set; }
}
