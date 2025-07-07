using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PicoStanowiskaWydruki
{
    public int PwrId { get; set; }

    public int? PwrPsaId { get; set; }

    public string? PwrNazwa { get; set; }

    public string? PwrNazwaPos { get; set; }

    public byte? PwrWysylaj { get; set; }

    public byte? PwrDomyslny { get; set; }

    public byte? PwrKopie { get; set; }

    public byte? PwrTyp { get; set; }

    public int? PwrRodzaj { get; set; }

    public int? PwrIdDefinicji { get; set; }

    public int? PwrCzasModyfikacji { get; set; }

    public virtual PicoStanowiska? PwrPsa { get; set; }
}
