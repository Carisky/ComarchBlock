using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class WdrZestawy
{
    public byte WdZStandardowy { get; set; }

    public int WdZId { get; set; }

    public string WdZNazwa { get; set; } = null!;

    public byte WdZRodzaj { get; set; }

    public string? WdZWarunek { get; set; }

    public string? WdZWarunekAuto { get; set; }

    public string? WdZOpis { get; set; }

    public string? WdZWersja { get; set; }

    public string? WdZAutor { get; set; }

    public string? WdZHaslo { get; set; }

    public string? WdZHasloChk { get; set; }

    public string? WdZEdycja { get; set; }

    public byte WdZKopiaEl { get; set; }

    public byte WdZKopiaElGdzie { get; set; }

    public byte WdZPodpisCyfrowy { get; set; }

    public int? WdZOpeZalId { get; set; }

    public DateTime WdZTsZal { get; set; }

    public int? WdZOpeModId { get; set; }

    public DateTime WdZTsMod { get; set; }

    public string WdZOpeModKod { get; set; } = null!;

    public string WdZOpeModNazwisko { get; set; } = null!;

    public string WdZOpeZalKod { get; set; } = null!;

    public string WdZOpeZalNazwisko { get; set; } = null!;
}
