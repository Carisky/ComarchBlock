using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SkladyCelne
{
    public short? ScGidtyp { get; set; }

    public int? ScGidfirma { get; set; }

    public int ScGidnumer { get; set; }

    public short? ScGidlp { get; set; }

    public string? ScKod { get; set; }

    public string? ScNazwa { get; set; }

    public string? ScKodP { get; set; }

    public string? ScMiasto { get; set; }

    public string? ScUlica { get; set; }

    public string? ScAdres { get; set; }

    public string? ScOpis { get; set; }

    public byte? ScSposobRozliczenia { get; set; }

    public virtual ICollection<Sczasoby> Sczasobies { get; set; } = new List<Sczasoby>();
}
