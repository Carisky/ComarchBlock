using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Pytanium
{
    public int PytId { get; set; }

    public int? PytGrupaId { get; set; }

    public string? PytTresc { get; set; }

    public short? PytOtwarte { get; set; }

    public string? PytAktywne { get; set; }

    public int? PytRodpId { get; set; }

    public string? PytWielokrotnyWybor { get; set; }

    public virtual ICollection<PytaniaZadanium> PytaniaZadania { get; set; } = new List<PytaniaZadanium>();
}
