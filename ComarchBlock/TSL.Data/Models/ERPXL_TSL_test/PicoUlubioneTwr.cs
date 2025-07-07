using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PicoUlubioneTwr
{
    public int PutPicoId { get; set; }

    public int PutTwrNumer { get; set; }

    public short? PutPozycja { get; set; }

    public virtual PicoKonfig PutPico { get; set; } = null!;

    public virtual TwrKarty PutTwrNumerNavigation { get; set; } = null!;
}
