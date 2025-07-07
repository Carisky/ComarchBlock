using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Nazwy
{
    public int NazGidtyp { get; set; }

    public int NazGidfirma { get; set; }

    public int NazGidnumer { get; set; }

    public int NazGidlp { get; set; }

    public string NazNazwa { get; set; } = null!;

    public string NazNazwa1 { get; set; } = null!;

    public string NazOpis { get; set; } = null!;
}
