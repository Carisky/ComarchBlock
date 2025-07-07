using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class WyposazenieAielem
{
    public int WypAieWypAieid { get; set; }

    public int WypAieWypAinid { get; set; }

    public int? WypAieWypId { get; set; }

    public int WypAieLp { get; set; }

    public string WypAieNrInwent { get; set; } = null!;

    public string WypAieKodKreskowy { get; set; } = null!;

    public int WypAieUniqueKodKreskowyBuster { get; set; }

    public string WypAieNazwa { get; set; } = null!;

    public string WypAieJednostkaMiary { get; set; } = null!;

    public decimal WypAieWartoscZak { get; set; }

    public decimal WypAieIlosc { get; set; }

    public decimal WypAieStanBiez { get; set; }

    public decimal? WypAieRoznica { get; set; }

    public virtual WyposazenieAinag WypAieWypAin { get; set; } = null!;
}
