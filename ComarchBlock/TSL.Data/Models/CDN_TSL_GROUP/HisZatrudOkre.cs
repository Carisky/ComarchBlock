using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class HisZatrudOkre
{
    public int HzoHzoId { get; set; }

    public int HzoHztId { get; set; }

    public int HzoDkmId { get; set; }

    public DateTime HzoOkresOd { get; set; }

    public DateTime HzoOkresDo { get; set; }

    public int? HzoOpeZalId { get; set; }

    public int? HzoStaZalId { get; set; }

    public DateTime HzoTsZal { get; set; }

    public int? HzoOpeModId { get; set; }

    public int? HzoStaModId { get; set; }

    public DateTime HzoTsMod { get; set; }

    public string HzoOpeModKod { get; set; } = null!;

    public string HzoOpeModNazwisko { get; set; } = null!;

    public string HzoOpeZalKod { get; set; } = null!;

    public string HzoOpeZalNazwisko { get; set; } = null!;

    public string? HzoImportRowId { get; set; }

    public virtual DaneKadMod HzoDkm { get; set; } = null!;

    public virtual HisZatrud HzoHzt { get; set; } = null!;
}
