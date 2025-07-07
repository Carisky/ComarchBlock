using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ZstPromocje
{
    public int ZprId { get; set; }

    public int? ZprPrmId { get; set; }

    public short? ZprTwrTyp { get; set; }

    public int? ZprTwrFirma { get; set; }

    public int? ZprTwrNumer { get; set; }

    public short? ZprTwrLp { get; set; }

    public string? ZprNazwa { get; set; }

    public virtual PrmKarty? ZprPrm { get; set; }
}
