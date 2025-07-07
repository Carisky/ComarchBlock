using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class WymPowiazanium
{
    public int WmpWmrId { get; set; }

    public int? WmpPowiazanieId { get; set; }

    public byte? WmpTypPowiazania { get; set; }

    public virtual Wymiary WmpWmr { get; set; } = null!;
}
