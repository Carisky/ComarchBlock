using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class Uprawnienium
{
    public int UprUprId { get; set; }

    public int UprPraId { get; set; }

    public int? UprDkmId { get; set; }

    public byte UprRodzaj { get; set; }

    public string UprNazwa { get; set; } = null!;

    public byte UprWymagLubMowa { get; set; }

    public byte UprUkonLubPismo { get; set; }

    public string UprStMowa { get; set; } = null!;

    public string UprStPismo { get; set; } = null!;

    public DateTime? UprKursOd { get; set; }

    public DateTime? UprKursDo { get; set; }

    public DateTime? UprKursTermin { get; set; }

    public string UprOpis { get; set; } = null!;

    public byte UprPrzypomnienie { get; set; }

    public byte UprZrodlo { get; set; }

    public byte UprNieaktywne { get; set; }

    public int? UprOpeZalId { get; set; }

    public int? UprStaZalId { get; set; }

    public DateTime UprTsZal { get; set; }

    public int? UprOpeModId { get; set; }

    public int? UprStaModId { get; set; }

    public DateTime UprTsMod { get; set; }

    public string UprOpeModKod { get; set; } = null!;

    public string UprOpeModNazwisko { get; set; } = null!;

    public string UprOpeZalKod { get; set; } = null!;

    public string UprOpeZalNazwisko { get; set; } = null!;

    public string? UprImportRowId { get; set; }

    public virtual DaneKadMod? UprDkm { get; set; }

    public virtual PracKod UprPra { get; set; } = null!;
}
