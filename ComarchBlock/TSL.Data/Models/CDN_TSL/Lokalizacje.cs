using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class Lokalizacje
{
    public int LokLokId { get; set; }

    public string LokKod { get; set; } = null!;

    public string LokNazwa { get; set; } = null!;

    public string LokSymbol { get; set; } = null!;

    public string LokKonto { get; set; } = null!;

    public short LokNieaktywny { get; set; }

    public string? LokImportAppId { get; set; }

    public string? LokImportRowId { get; set; }

    public DateTime? LokTsExport { get; set; }

    public int? LokOpeZalId { get; set; }

    public int? LokStaZalId { get; set; }

    public DateTime LokTsZal { get; set; }

    public int? LokOpeModId { get; set; }

    public int? LokStaModId { get; set; }

    public DateTime LokTsMod { get; set; }

    public string LokOpeModKod { get; set; } = null!;

    public string LokOpeModNazwisko { get; set; } = null!;

    public string LokOpeZalKod { get; set; } = null!;

    public string LokOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<Dzialy> Dzialies { get; set; } = new List<Dzialy>();
}
