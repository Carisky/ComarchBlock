using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdZwiazane
{
    public int PzwId { get; set; }

    public short? PzwZrdTyp { get; set; }

    public int? PzwZrdFirma { get; set; }

    public int? PzwZrdNumer { get; set; }

    public short? PzwZrdLp { get; set; }

    public short? PzwDokTyp { get; set; }

    public int? PzwDokFirma { get; set; }

    public int? PzwDokNumer { get; set; }

    public short? PzwDokLp { get; set; }

    public int? PzwPolprodPartia { get; set; }

    public int? PzwPtzpartia { get; set; }
}
