using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class ESklepFormyPlatnosci
{
    public int EsfEsfid { get; set; }

    public int EsfEssid { get; set; }

    public int? EsfIgfplId { get; set; }

    public int EsfFplId { get; set; }

    public string EsfNazwa { get; set; } = null!;

    public byte EsfAktywna { get; set; }

    public byte EsfPlatOnline { get; set; }

    public virtual ESklepStanowiska EsfEss { get; set; } = null!;
}
