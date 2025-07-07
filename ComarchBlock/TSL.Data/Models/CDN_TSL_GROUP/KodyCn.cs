using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class KodyCn
{
    public int KcnKcnid { get; set; }

    public string KcnKod { get; set; } = null!;

    public string KcnKodSent { get; set; } = null!;

    public int KcnSent { get; set; }

    public string KcnOpis { get; set; } = null!;

    public string KcnUzupJm { get; set; } = null!;

    public string KcnJmsent { get; set; } = null!;

    public byte KcnMasa { get; set; }

    public decimal? KcnStawka { get; set; }

    public short? KcnFlaga { get; set; }

    public decimal? KcnZrodlowa { get; set; }

    public int? KcnOpeZalId { get; set; }

    public int? KcnStaZalId { get; set; }

    public DateTime KcnTsZal { get; set; }

    public int? KcnOpeModId { get; set; }

    public int? KcnStaModId { get; set; }

    public DateTime KcnTsMod { get; set; }

    public string KcnOpeModKod { get; set; } = null!;

    public string KcnOpeModNazwisko { get; set; } = null!;

    public string KcnOpeZalKod { get; set; } = null!;

    public string KcnOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<Towary> Towaries { get; set; } = new List<Towary>();
}
