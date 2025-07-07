using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class SchematyWindykacji
{
    public int SwNSwNid { get; set; }

    public string SwNKod { get; set; } = null!;

    public string SwNNazwa { get; set; } = null!;

    public byte SwNDomyslny { get; set; }

    public byte SwNNieaktywny { get; set; }

    public int? SwNOpeZalId { get; set; }

    public int? SwNStaZalId { get; set; }

    public DateTime SwNTsZal { get; set; }

    public int? SwNOpeModId { get; set; }

    public int? SwNStaModId { get; set; }

    public DateTime SwNTsMod { get; set; }

    public string SwNOpeModKod { get; set; } = null!;

    public string SwNOpeModNazwisko { get; set; } = null!;

    public string SwNOpeZalKod { get; set; } = null!;

    public string SwNOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<SchematWindykacjiEtapy> SchematWindykacjiEtapies { get; set; } = new List<SchematWindykacjiEtapy>();
}
