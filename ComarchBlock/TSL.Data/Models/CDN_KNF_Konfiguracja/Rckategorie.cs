using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Rckategorie
{
    public int RckRckid { get; set; }

    public string RckKod { get; set; } = null!;

    public string RckNazwa { get; set; } = null!;

    public decimal RckStawka { get; set; }

    public virtual ICollection<Rcsesje> Rcsesjes { get; set; } = new List<Rcsesje>();
}
