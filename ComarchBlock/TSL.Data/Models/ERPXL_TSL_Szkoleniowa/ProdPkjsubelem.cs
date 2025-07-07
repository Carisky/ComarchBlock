using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdPkjsubelem
{
    public int PkjsId { get; set; }

    public int? PkjsPkjnid { get; set; }

    public short? PkjsGidtyp { get; set; }

    public int? PkjsGidfirma { get; set; }

    public int? PkjsGidnumer { get; set; }

    public short? PkjsGidlp { get; set; }

    public short? PkjsSubGidlp { get; set; }

    public virtual ProdPkjnag? PkjsPkjn { get; set; }
}
