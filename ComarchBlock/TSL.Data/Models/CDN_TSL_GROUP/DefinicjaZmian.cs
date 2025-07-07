using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DefinicjaZmian
{
    public int DfzDfzId { get; set; }

    public string DfzNazwa { get; set; } = null!;

    public int? DfzPole1 { get; set; }

    public int? DfzPole2 { get; set; }

    public int? DfzPole3 { get; set; }

    public string DfzWzor1 { get; set; } = null!;

    public string DfzWzor2 { get; set; } = null!;

    public string DfzWzor3 { get; set; } = null!;

    public string DfzWzor { get; set; } = null!;

    public byte DfzInteraktywna { get; set; }

    public byte DfzAktualizacja { get; set; }

    public int DfzStandardowy { get; set; }

    public byte DfzNieaktywny { get; set; }

    public byte DfzZaawansowany { get; set; }

    public virtual ICollection<DefinicjaZmianPola> DefinicjaZmianPolas { get; set; } = new List<DefinicjaZmianPola>();

    public virtual DanePlacMod? DfzPole1Navigation { get; set; }

    public virtual DanePlacMod? DfzPole2Navigation { get; set; }

    public virtual DanePlacMod? DfzPole3Navigation { get; set; }
}
