using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class Dzienniki
{
    public int DziDziId { get; set; }

    public string DziSymbol { get; set; } = null!;

    public string DziNazwa { get; set; } = null!;

    public int DziOobId { get; set; }

    public int? DziOpeZalId { get; set; }

    public int? DziStaZalId { get; set; }

    public DateTime DziTsZal { get; set; }

    public int? DziOpeModId { get; set; }

    public int? DziStaModId { get; set; }

    public DateTime DziTsMod { get; set; }

    public string DziOpeModKod { get; set; } = null!;

    public string DziOpeModNazwisko { get; set; } = null!;

    public string DziOpeZalKod { get; set; } = null!;

    public string DziOpeZalNazwisko { get; set; } = null!;

    public virtual OkresyObrach DziOob { get; set; } = null!;

    public virtual ICollection<DziennikZakazy> DziennikZakazies { get; set; } = new List<DziennikZakazy>();
}
