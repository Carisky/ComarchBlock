using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DeklKedu
{
    public int DkkDkkId { get; set; }

    public DateTime DkkData { get; set; }

    public string DkkNazwa { get; set; } = null!;

    public string DkkOpis { get; set; } = null!;

    public byte DkkZablokowana { get; set; }

    public int? DkkOpeZalId { get; set; }

    public int? DkkStaZalId { get; set; }

    public DateTime DkkTsZal { get; set; }

    public int? DkkOpeModId { get; set; }

    public int? DkkStaModId { get; set; }

    public DateTime DkkTsMod { get; set; }

    public string DkkOpeModKod { get; set; } = null!;

    public string DkkOpeModNazwisko { get; set; } = null!;

    public string DkkOpeZalKod { get; set; } = null!;

    public string DkkOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<DeklNag> DeklNags { get; set; } = new List<DeklNag>();
}
