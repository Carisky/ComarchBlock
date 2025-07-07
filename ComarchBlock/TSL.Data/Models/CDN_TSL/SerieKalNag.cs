using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class SerieKalNag
{
    public int SlnSlnId { get; set; }

    public string SlnSymbol { get; set; } = null!;

    public string SlnNazwa { get; set; } = null!;

    public string SlnOpis { get; set; } = null!;

    public int? SlnOpeZalId { get; set; }

    public int? SlnStaZalId { get; set; }

    public DateTime SlnTsZal { get; set; }

    public int? SlnOpeModId { get; set; }

    public int? SlnStaModId { get; set; }

    public DateTime SlnTsMod { get; set; }

    public string SlnOpeModKod { get; set; } = null!;

    public string SlnOpeModNazwisko { get; set; } = null!;

    public string SlnOpeZalKod { get; set; } = null!;

    public string SlnOpeZalNazwisko { get; set; } = null!;

    public string? SlnImportRowId { get; set; }

    public virtual ICollection<SerieKalPoz> SerieKalPozs { get; set; } = new List<SerieKalPoz>();
}
