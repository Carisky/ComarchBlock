using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class GrupyTemp
{
    public short RpgGidtyp { get; set; }

    public int? RpgGidfirma { get; set; }

    public int RpgGidnumer { get; set; }

    public short RpgGidlp { get; set; }

    public string RpgGrupa { get; set; } = null!;

    public string RpgSortowanie { get; set; } = null!;

    public short? RpgEleTyp { get; set; }

    public int? RpgEleFirma { get; set; }

    public int RpgEleNumer { get; set; }

    public short? RpgEleLp { get; set; }

    public int? RpgGroNumer { get; set; }
}
