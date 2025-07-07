using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class OdpowiedziZadaniaWielokrotne
{
    public int OzwZadId { get; set; }

    public int OzwPytId { get; set; }

    public string? OzwTresc { get; set; }

    public int OzwOdpId { get; set; }

    public virtual OdpowiedziZadanium OdpowiedziZadanium { get; set; } = null!;
}
