using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TypWyplataGrupa
{
    public int TwyTwyId { get; set; }

    public string TwyNazwa { get; set; } = null!;

    public byte TwyNieaktywna { get; set; }

    public int? TwyOpeZalId { get; set; }

    public int? TwyStaZalId { get; set; }

    public DateTime TwyTsZal { get; set; }

    public int? TwyOpeModId { get; set; }

    public int? TwyStaModId { get; set; }

    public DateTime TwyTsMod { get; set; }

    public string TwyOpeModKod { get; set; } = null!;

    public string TwyOpeModNazwisko { get; set; } = null!;

    public string TwyOpeZalKod { get; set; } = null!;

    public string TwyOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<TypWyplataGrupaSkladniki> TypWyplataGrupaSkladnikis { get; set; } = new List<TypWyplataGrupaSkladniki>();
}
