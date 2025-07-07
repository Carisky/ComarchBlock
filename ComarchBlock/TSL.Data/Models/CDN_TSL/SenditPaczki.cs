using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class SenditPaczki
{
    public int SpaSpaid { get; set; }

    public int SpaLp { get; set; }

    public int SpaSzlid { get; set; }

    public decimal SpaWaga { get; set; }

    public decimal SpaWysokosc { get; set; }

    public decimal SpaSzerokosc { get; set; }

    public decimal SpaDlugosc { get; set; }

    public string SpaSposobPakowania { get; set; } = null!;

    public string SpaSposobPakowaniaKey { get; set; } = null!;

    public decimal SpaKwotaUbezpieczenia { get; set; }

    public string SpaNumerListu { get; set; } = null!;

    public string SpaUrl { get; set; } = null!;

    public string SpaZawartosc { get; set; } = null!;

    public byte SpaGabaryt { get; set; }

    public byte SpaOstroznie { get; set; }

    public byte SpaNiestandardowa { get; set; }

    public decimal SpaDeklarowanaWartosc { get; set; }

    public string SpaIdentyfikatorUkuriera { get; set; } = null!;

    public virtual SenditZleceniePrzesylki SpaSzl { get; set; } = null!;
}
