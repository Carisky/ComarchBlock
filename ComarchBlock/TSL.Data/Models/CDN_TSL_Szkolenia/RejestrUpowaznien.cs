using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class RejestrUpowaznien
{
    public int RupRupid { get; set; }

    public int? RupLp { get; set; }

    public int RupPodId { get; set; }

    public short RupPodmiotTyp { get; set; }

    public string RupImieNazwisko { get; set; } = null!;

    public int? RupOsobaId { get; set; }

    public DateTime RupDataNadania { get; set; }

    public DateTime? RupDataUstania { get; set; }

    public string RupOpis { get; set; } = null!;

    public int? RupOpeZalId { get; set; }

    public int? RupOpeModId { get; set; }

    public int? RupStaZalId { get; set; }

    public int? RupStaModId { get; set; }

    public DateTime RupTsZal { get; set; }

    public DateTime RupTsMod { get; set; }

    public string RupOpeModKod { get; set; } = null!;

    public string RupOpeZalKod { get; set; } = null!;

    public string RupOpeModNazwisko { get; set; } = null!;

    public string RupOpeZalNazwisko { get; set; } = null!;

    public virtual PodmiotyView PodmiotyView { get; set; } = null!;

    public virtual KntOsoby? RupOsoba { get; set; }
}
