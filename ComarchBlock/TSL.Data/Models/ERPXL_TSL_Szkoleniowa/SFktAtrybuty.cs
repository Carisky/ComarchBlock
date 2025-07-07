using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SFktAtrybuty
{
    public int? AtrId { get; set; }

    public int? AtrOrgId { get; set; }

    public int? AtrWymTyp { get; set; }

    public int? AtrOrgAtrId { get; set; }

    public int? AtrOrgWymId { get; set; }

    public int? AtrWymFirma { get; set; }

    public string? AtrObjOrgId { get; set; }

    public int? AtrObjTyp { get; set; }

    public int? AtrObjNumer { get; set; }

    public int? AtrObjLp { get; set; }

    public int? AtrObjSubLp { get; set; }

    public int AtrTypKwoty { get; set; }

    public int AtrKierunek { get; set; }

    public int? WsadInsertId { get; set; }
}
