using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class V2BsoftNmuwagi
{
    public short? Typ { get; set; }

    public int? Firma { get; set; }

    public int Numer { get; set; }

    public string Korygowana { get; set; } = null!;

    public string Prawidlowa { get; set; } = null!;
}
