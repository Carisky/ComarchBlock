using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class XlbiKntGeografium
{
    public int KgeKntNumer { get; set; }

    public int? KgeKntTyp { get; set; }

    public string? KgeGeografiaOrgId { get; set; }

    public int? KgeKrajId { get; set; }

    public int? KgeWojId { get; set; }

    public int? KgePowiatId { get; set; }

    public int? KgeGminaId { get; set; }
}
