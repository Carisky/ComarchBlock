using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class AnkGrupyPytan
{
    public int AnkGpAnkGpId { get; set; }

    public string AnkGpNazwa { get; set; } = null!;

    public string AnkGpOpis { get; set; } = null!;

    public int AnkGpWaga { get; set; }

    public byte AnkGpDomyslna { get; set; }

    public byte AnkGpNieaktywna { get; set; }

    public int? AnkGpOpeZalId { get; set; }

    public int? AnkGpStaZalId { get; set; }

    public DateTime AnkGpTsZal { get; set; }

    public int? AnkGpOpeModId { get; set; }

    public int? AnkGpStaModId { get; set; }

    public DateTime AnkGpTsMod { get; set; }

    public string AnkGpOpeModKod { get; set; } = null!;

    public string AnkGpOpeModNazwisko { get; set; } = null!;

    public string AnkGpOpeZalKod { get; set; } = null!;

    public string AnkGpOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<AnkSlownikPytan> AnkSlownikPytans { get; set; } = new List<AnkSlownikPytan>();
}
