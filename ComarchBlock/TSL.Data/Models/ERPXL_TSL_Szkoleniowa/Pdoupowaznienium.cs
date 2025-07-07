using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Pdoupowaznienium
{
    public int PdouId { get; set; }

    public string? PdouImieNazwisko { get; set; }

    public string? PdouZakresUpowaznienia { get; set; }

    public int? PdouDataNadania { get; set; }

    public int? PdouDataUstania { get; set; }

    public short? PdouObiTyp { get; set; }

    public int? PdouObiNumer { get; set; }

    public short? PdouObiLp { get; set; }

    public byte? PdouAktywne { get; set; }

    public int? PdouRodzajUpowaznieniaId { get; set; }

    public int? PdouOpeWnumer { get; set; }

    public int? PdouOpeMnumer { get; set; }

    public int? PdouOpeZnumer { get; set; }

    public int? PdouCzasUtworzenia { get; set; }

    public int? PdouCzasModyfikacji { get; set; }

    public int? PdouCzasArchiwizacji { get; set; }
}
