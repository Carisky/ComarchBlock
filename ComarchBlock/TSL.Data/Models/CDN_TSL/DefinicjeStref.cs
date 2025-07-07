using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DefinicjeStref
{
    public int DstDstId { get; set; }

    public string DstAkronim { get; set; } = null!;

    public string DstNazwa { get; set; } = null!;

    public byte DstUwzglCzasPracy { get; set; }

    public string DstSymbol { get; set; } = null!;

    public decimal DstProcentWynZas { get; set; }

    public byte DstStandardowy { get; set; }

    public byte DstNieaktywny { get; set; }

    public int? DstOpeZalId { get; set; }

    public int? DstStaZalId { get; set; }

    public DateTime DstTsZal { get; set; }

    public int? DstOpeModId { get; set; }

    public int? DstStaModId { get; set; }

    public DateTime DstTsMod { get; set; }

    public string DstOpeModKod { get; set; } = null!;

    public string DstOpeModNazwisko { get; set; } = null!;

    public string DstOpeZalKod { get; set; } = null!;

    public string DstOpeZalNazwisko { get; set; } = null!;

    public string? DstImportRowId { get; set; }

    public virtual ICollection<WypSkladniki> WypSkladnikis { get; set; } = new List<WypSkladniki>();
}
