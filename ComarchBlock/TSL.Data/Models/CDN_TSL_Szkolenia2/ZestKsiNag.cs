using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class ZestKsiNag
{
    public int ZknZknid { get; set; }

    public short ZknNieaktywne { get; set; }

    public string ZknSymbol { get; set; } = null!;

    public int? ZknTypZestawienia { get; set; }

    public int? ZknTypJednostki { get; set; }

    public short ZknTypZest { get; set; }

    public string ZknNazwa { get; set; } = null!;

    public string ZknOpis { get; set; } = null!;

    public byte ZknBufor { get; set; }

    public string ZknNumeracja { get; set; } = null!;

    public DateTime? ZknTsOblicz { get; set; }

    public int? ZknOpeZalId { get; set; }

    public int? ZknStaZalId { get; set; }

    public DateTime ZknTsZal { get; set; }

    public int? ZknOpeModId { get; set; }

    public int? ZknStaModId { get; set; }

    public DateTime ZknTsMod { get; set; }

    public string ZknOpeModKod { get; set; } = null!;

    public string ZknOpeModNazwisko { get; set; } = null!;

    public string ZknOpeZalKod { get; set; } = null!;

    public string ZknOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<ZestKsiKol> ZestKsiKols { get; set; } = new List<ZestKsiKol>();

    public virtual ICollection<ZestKsiPoz> ZestKsiPozs { get; set; } = new List<ZestKsiPoz>();

    public virtual ICollection<ZestKsiWyniki> ZestKsiWynikis { get; set; } = new List<ZestKsiWyniki>();
}
