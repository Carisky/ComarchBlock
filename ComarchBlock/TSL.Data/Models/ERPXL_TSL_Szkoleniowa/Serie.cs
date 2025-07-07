using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Serie
{
    public short? SerGidtyp { get; set; }

    public int? SerGidfirma { get; set; }

    public int SerGidnumer { get; set; }

    public short? SerGidlp { get; set; }

    public string SerNazwa { get; set; } = null!;

    public string? SerOpis { get; set; }

    public string? SerRejVatspr { get; set; }

    public string? SerRejVatzak { get; set; }

    public byte? SerOddzial { get; set; }

    public short? SerZwrTyp { get; set; }

    public int? SerZwrFirma { get; set; }

    public int? SerZwrNumer { get; set; }

    public short? SerZwrLp { get; set; }

    public int? SerCzasModyfikacji { get; set; }

    public byte? SerKorekta { get; set; }

    public short? SerPredefiniowana { get; set; }

    public virtual ICollection<Kbnnag> KbnsKbnns { get; set; } = new List<Kbnnag>();
}
