using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class OkresyObrach
{
    public int OobOobId { get; set; }

    public string OobSymbol { get; set; } = null!;

    public DateTime OobDataOtw { get; set; }

    public short OobDlugosc { get; set; }

    public DateTime OobDataKoncowa { get; set; }

    public DateTime? OobDataZam { get; set; }

    public int OobCiaglaNumeracjaDc { get; set; }

    public int OobZaliczkiUproszczone { get; set; }

    public short OobStan { get; set; }

    public string OobOpis { get; set; } = null!;

    public int? OobDziIdRk { get; set; }

    public int? OobDziIdKomp { get; set; }

    public short OobDataKsiRk { get; set; }

    public short OobDataKsiKomp { get; set; }

    public int? OobOpeZalId { get; set; }

    public int? OobStaZalId { get; set; }

    public DateTime OobTsZal { get; set; }

    public int? OobOpeModId { get; set; }

    public int? OobStaModId { get; set; }

    public DateTime OobTsMod { get; set; }

    public string OobOpeModKod { get; set; } = null!;

    public string OobOpeModNazwisko { get; set; } = null!;

    public string OobOpeZalKod { get; set; } = null!;

    public string OobOpeZalNazwisko { get; set; } = null!;

    public string? OobTypZoiS { get; set; }

    public virtual ICollection<Bonag> Bonags { get; set; } = new List<Bonag>();

    public virtual ICollection<Dzienniki> Dziennikis { get; set; } = new List<Dzienniki>();

    public virtual ICollection<GrupyKontNag> GrupyKontNags { get; set; } = new List<GrupyKontNag>();

    public virtual ICollection<Kontum> Konta { get; set; } = new List<Kontum>();

    public virtual ICollection<KragKosztNag> KragKosztNags { get; set; } = new List<KragKosztNag>();
}
