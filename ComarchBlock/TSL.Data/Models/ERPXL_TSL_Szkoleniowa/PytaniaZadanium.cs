using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PytaniaZadanium
{
    public int PyzZadId { get; set; }

    public int? PyzAntId { get; set; }

    public int PyzPytId { get; set; }

    public decimal? PyzPytWaga { get; set; }

    public decimal? PyzGrupWaga { get; set; }

    public string? PyzOpis { get; set; }

    public short? PyzPozycja { get; set; }

    public virtual Pytanium PyzPyt { get; set; } = null!;

    public virtual Zadanium PyzZad { get; set; } = null!;
}
