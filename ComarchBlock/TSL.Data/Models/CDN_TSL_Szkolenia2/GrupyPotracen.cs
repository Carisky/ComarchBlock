using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class GrupyPotracen
{
    public int GprGprId { get; set; }

    public string GprNazwa { get; set; } = null!;

    public string GprSkrot { get; set; } = null!;

    public decimal GprKwotaEgzekucji1 { get; set; }

    public decimal GprKwotaEgzekucji2 { get; set; }

    public decimal GprKwotaEgzekucji3 { get; set; }

    public decimal GprKwotaWolna { get; set; }

    public byte GprPropWymiarEtatu { get; set; }

    public decimal GprKwotaEgzekucjiZus { get; set; }

    public decimal GprKwotaWolnaZus { get; set; }

    public decimal GprKwotaWolnaZus2 { get; set; }

    public byte GprPropWymiarEtatuZus { get; set; }

    public byte GprNieaktywna { get; set; }

    public short GprStandardowy { get; set; }

    public int GprPriorytet { get; set; }

    public byte GprPropDniZasilku { get; set; }

    public byte GprRodzajKwotyWolnejZus { get; set; }

    public byte GprKwotaPobranaKonf { get; set; }

    public int GprKwotaRodzajPotracenia { get; set; }

    public int? GprOpeZalId { get; set; }

    public int? GprStaZalId { get; set; }

    public DateTime? GprTsZal { get; set; }

    public int? GprOpeModId { get; set; }

    public int? GprStaModId { get; set; }

    public DateTime? GprTsMod { get; set; }

    public string GprOpeModKod { get; set; } = null!;

    public string GprOpeModNazwisko { get; set; } = null!;

    public string GprOpeZalKod { get; set; } = null!;

    public string GprOpeZalNazwisko { get; set; } = null!;

    public string? GprImportRowId { get; set; }

    public virtual ICollection<GrupyPotrSkladniki> GrupyPotrSkladnikis { get; set; } = new List<GrupyPotrSkladniki>();
}
