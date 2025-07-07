using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class IstSelem
{
    public short IsSGidtyp { get; set; }

    public int? IsSGidfirma { get; set; }

    public int IsSGidnumer { get; set; }

    public short IsSGidlp { get; set; }

    public int IsSSubGidlp { get; set; }

    public decimal? IsSMasaNetto { get; set; }

    public decimal? IsSIloscJmuzup { get; set; }

    public decimal? IsSWartoscFakt { get; set; }

    public decimal? IsSWartoscStat { get; set; }

    public short? IsSDokTyp { get; set; }

    public int? IsSDokFirma { get; set; }

    public int? IsSDokNumer { get; set; }

    public short? IsSDokLp { get; set; }

    public short? IsSDokStan { get; set; }

    public byte? IsSTrNkosztUstalono { get; set; }

    public string? IsSJmu { get; set; }

    public virtual IstElem IstElem { get; set; } = null!;
}
