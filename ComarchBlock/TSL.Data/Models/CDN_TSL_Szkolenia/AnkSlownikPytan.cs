using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class AnkSlownikPytan
{
    public int AnkSpAnkSpId { get; set; }

    public string AnkSpTresc { get; set; } = null!;

    public string AnkSpOpis { get; set; } = null!;

    public int? AnkSpAnkGpId { get; set; }

    public byte AnkSpTypPytania { get; set; }

    public byte AnkSpFormatPytOtwartego { get; set; }

    public byte AnkSpWielokrotnyWybor { get; set; }

    public int? AnkSpAnkSonId { get; set; }

    public int AnkSpAnkSonAuto { get; set; }

    public int AnkSpWaga { get; set; }

    public byte AnkSpOdpWymagana { get; set; }

    public byte AnkSpNieaktywne { get; set; }

    public byte AnkSpAktualizujSzablonOdp { get; set; }

    public int? AnkSpOpeZalId { get; set; }

    public int? AnkSpStaZalId { get; set; }

    public DateTime AnkSpTsZal { get; set; }

    public int? AnkSpOpeModId { get; set; }

    public int? AnkSpStaModId { get; set; }

    public DateTime AnkSpTsMod { get; set; }

    public string AnkSpOpeModKod { get; set; } = null!;

    public string AnkSpOpeModNazwisko { get; set; } = null!;

    public string AnkSpOpeZalKod { get; set; } = null!;

    public string AnkSpOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<AnkSlownikPytanOdp> AnkSlownikPytanOdps { get; set; } = new List<AnkSlownikPytanOdp>();

    public virtual AnkGrupyPytan? AnkSpAnkGp { get; set; }
}
