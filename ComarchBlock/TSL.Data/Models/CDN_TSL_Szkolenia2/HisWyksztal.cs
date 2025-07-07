using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class HisWyksztal
{
    public int HwyHwyId { get; set; }

    public int HwyPraId { get; set; }

    public string HwyNazwa { get; set; } = null!;

    public DateTime? HwyOkresOd { get; set; }

    public DateTime? HwyOkresDo { get; set; }

    public string HwyZawod { get; set; } = null!;

    public string HwySpecjalnosc { get; set; } = null!;

    public string HwyStopien { get; set; } = null!;

    public string HwyTytul { get; set; } = null!;

    public int HwyStazLata { get; set; }

    public int HwyStazMies { get; set; }

    public int HwyStazDni { get; set; }

    public byte HwyStazWliczac { get; set; }

    public int? HwyOpeZalId { get; set; }

    public int? HwyStaZalId { get; set; }

    public DateTime HwyTsZal { get; set; }

    public int? HwyOpeModId { get; set; }

    public int? HwyStaModId { get; set; }

    public DateTime HwyTsMod { get; set; }

    public string HwyOpeModKod { get; set; } = null!;

    public string HwyOpeModNazwisko { get; set; } = null!;

    public string HwyOpeZalKod { get; set; } = null!;

    public string HwyOpeZalNazwisko { get; set; } = null!;

    public string? HwyImportRowId { get; set; }

    public virtual PracKod HwyPra { get; set; } = null!;
}
