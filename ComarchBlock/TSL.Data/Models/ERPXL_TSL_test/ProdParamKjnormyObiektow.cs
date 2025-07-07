using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdParamKjnormyObiektow
{
    public int PpkoId { get; set; }

    public int PpkoPkjid { get; set; }

    public short PpkoOgidTyp { get; set; }

    public int PpkoOgidNumer { get; set; }

    public int? PpkoLp { get; set; }

    public string? PpkoOpis { get; set; }

    public string? PpkoUrl { get; set; }

    public string? PpkoJednostka { get; set; }

    public string? PpkoWartosc { get; set; }

    public decimal? PpkoWynikIlosc { get; set; }

    public int? PpkoWkjid { get; set; }

    public virtual ProdParametryKj PpkoPkj { get; set; } = null!;

    public virtual ICollection<ProdParametryKjnormy> ProdParametryKjnormies { get; set; } = new List<ProdParametryKjnormy>();
}
