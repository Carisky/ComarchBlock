using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class Zaniechanium
{
    public int ZanZanId { get; set; }

    public int ZanPraId { get; set; }

    public string ZanNazwa { get; set; } = null!;

    public int ZanSposob { get; set; }

    public decimal ZanKwotaZan { get; set; }

    public decimal ZanKwotaRoz { get; set; }

    public decimal ZanKwotaTemp { get; set; }

    public DateTime ZanData { get; set; }

    public int? ZanOpeZalId { get; set; }

    public int? ZanStaZalId { get; set; }

    public DateTime ZanTsZal { get; set; }

    public int? ZanOpeModId { get; set; }

    public int? ZanStaModId { get; set; }

    public DateTime ZanTsMod { get; set; }

    public string ZanOpeModKod { get; set; } = null!;

    public string ZanOpeModNazwisko { get; set; } = null!;

    public string ZanOpeZalKod { get; set; } = null!;

    public string ZanOpeZalNazwisko { get; set; } = null!;

    public virtual PracKod ZanPra { get; set; } = null!;

    public virtual ICollection<ZaniechaniaRoz> ZaniechaniaRozs { get; set; } = new List<ZaniechaniaRoz>();
}
