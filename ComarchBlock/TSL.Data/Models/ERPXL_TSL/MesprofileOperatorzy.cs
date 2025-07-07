using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class MesprofileOperatorzy
{
    public int MespoId { get; set; }

    public int? MespoProfilId { get; set; }

    public string? MespoKodOperatora { get; set; }

    public int? MespoOpeGidNumer { get; set; }

    public byte? MespoDomyslny { get; set; }
}
