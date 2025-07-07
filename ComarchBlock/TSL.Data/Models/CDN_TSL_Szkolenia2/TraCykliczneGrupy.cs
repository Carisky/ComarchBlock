using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TraCykliczneGrupy
{
    public int TcgGrupa { get; set; }

    public int TcgJestCykliczna { get; set; }

    public int? TcgTrnId { get; set; }

    public DateTime? TcgDataMod { get; set; }

    public string? TcgKontrahenci { get; set; }

    public string? TcgTowary { get; set; }

    public int? TcgUkryj { get; set; }
}
