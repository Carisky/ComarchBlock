using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DanePlacMod
{
    public int DpmDpmId { get; set; }

    public int DpmKod { get; set; }

    public byte DpmRodzaj { get; set; }

    public decimal? DpmWartosc { get; set; }

    public string DpmOpis { get; set; } = null!;

    public string DpmNazwa { get; set; } = null!;

    public byte DpmNieaktywny { get; set; }

    public string DpmFormat { get; set; } = null!;

    public string DpmDodatkowe { get; set; } = null!;

    public string DpmKolekcja { get; set; } = null!;

    public string DpmInne { get; set; } = null!;

    public string DpmKolejkaWartosc { get; set; } = null!;

    public string DpmKolejkaOpis { get; set; } = null!;

    public int DpmTag { get; set; }

    public string DpmZjeId { get; set; } = null!;

    public virtual ICollection<DefinicjaZmian> DefinicjaZmianDfzPole1Navigations { get; set; } = new List<DefinicjaZmian>();

    public virtual ICollection<DefinicjaZmian> DefinicjaZmianDfzPole2Navigations { get; set; } = new List<DefinicjaZmian>();

    public virtual ICollection<DefinicjaZmian> DefinicjaZmianDfzPole3Navigations { get; set; } = new List<DefinicjaZmian>();
}
