using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class Awizo
{
    public int AwzAwzid { get; set; }

    public string AwzNumer { get; set; } = null!;

    public DateTime AwzData { get; set; }

    public DateTime AwzDataDostawy { get; set; }

    public int AwzPodId { get; set; }

    public int AwzOdbId { get; set; }

    public int AwzTypTransportuId { get; set; }

    public int AwzWarunkiDostawyId { get; set; }

    public int AwzTrNid { get; set; }

    public DateTime AwzTsZal { get; set; }

    public int? AwzOpeModId { get; set; }

    public int? AwzStaModId { get; set; }

    public DateTime AwzTsMod { get; set; }

    public int? AwzOpeZalId { get; set; }

    public int? AwzStaZalId { get; set; }

    public string AwzOpeModKod { get; set; } = null!;

    public string AwzOpeModNazwisko { get; set; } = null!;

    public string AwzOpeZalKod { get; set; } = null!;

    public string AwzOpeZalNazwisko { get; set; } = null!;

    public short AwzBufor { get; set; }

    public short? AwzPodTyp { get; set; }

    public short? AwzOdbTyp { get; set; }

    public virtual ICollection<AwizoOpakowanium> AwizoOpakowania { get; set; } = new List<AwizoOpakowanium>();

    public virtual ICollection<AwizoTowary> AwizoTowaries { get; set; } = new List<AwizoTowary>();
}
