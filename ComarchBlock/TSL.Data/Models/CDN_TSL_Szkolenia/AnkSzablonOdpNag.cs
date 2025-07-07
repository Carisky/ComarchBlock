using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class AnkSzablonOdpNag
{
    public int AnkSoNAnkSonId { get; set; }

    public string AnkSoNNazwa { get; set; } = null!;

    public int AnkSoNAuto { get; set; }

    public int? AnkSoNOpeZalId { get; set; }

    public int? AnkSoNStaZalId { get; set; }

    public DateTime AnkSoNTsZal { get; set; }

    public int? AnkSoNOpeModId { get; set; }

    public int? AnkSoNStaModId { get; set; }

    public DateTime AnkSoNTsMod { get; set; }

    public string AnkSoNOpeModKod { get; set; } = null!;

    public string AnkSoNOpeModNazwisko { get; set; } = null!;

    public string AnkSoNOpeZalKod { get; set; } = null!;

    public string AnkSoNOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<AnkSzablonOdpElem> AnkSzablonOdpElems { get; set; } = new List<AnkSzablonOdpElem>();
}
