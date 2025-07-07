using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class RelTraImp
{
    public int RtiId { get; set; }

    public short? RtiZrdTyp { get; set; }

    public int? RtiZrdFirma { get; set; }

    public int? RtiZrdNumer { get; set; }

    public short? RtiZrdLp { get; set; }

    public short? RtiDocTyp { get; set; }

    public int? RtiDocFirma { get; set; }

    public int? RtiDocNumer { get; set; }

    public short? RtiDocLp { get; set; }

    public int? RtiCzasDodania { get; set; }
}
