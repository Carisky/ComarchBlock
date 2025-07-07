using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Nazwy
{
    public short NazGidtyp { get; set; }

    public int? NazGidfirma { get; set; }

    public int? NazGidnumer { get; set; }

    public short NazGidlp { get; set; }

    public string? NazNazwa { get; set; }

    public string? NazNazwa1 { get; set; }

    public string? NazOpis { get; set; }

    public byte? NazArchiwalny { get; set; }

    public int? NazCzasModyfikacji { get; set; }

    public byte? NazPredefiniowana { get; set; }

    public string? NazNazwa2 { get; set; }

    public virtual ICollection<NazRelacje> NazRelacjes { get; set; } = new List<NazRelacje>();

    public virtual ICollection<PicoSposobyDst> PicoSposobyDsts { get; set; } = new List<PicoSposobyDst>();
}
