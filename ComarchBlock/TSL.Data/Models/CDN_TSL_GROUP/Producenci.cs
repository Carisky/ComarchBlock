using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Producenci
{
    public int PrdPrdId { get; set; }

    public string PrdKod { get; set; } = null!;

    public string PrdNazwa { get; set; } = null!;

    public string? PrdUrl { get; set; }

    public int? PrdLogo { get; set; }

    public int? PrdOpeZalId { get; set; }

    public int? PrdStaZalId { get; set; }

    public DateTime PrdTsZal { get; set; }

    public int? PrdOpeModId { get; set; }

    public int? PrdStaModId { get; set; }

    public DateTime PrdTsMod { get; set; }

    public string PrdOpeModKod { get; set; } = null!;

    public string PrdOpeModNazwisko { get; set; } = null!;

    public string PrdOpeZalKod { get; set; } = null!;

    public string PrdOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<Marki> Markis { get; set; } = new List<Marki>();

    public virtual ICollection<ProducenciJezykObcy> ProducenciJezykObcies { get; set; } = new List<ProducenciJezykObcy>();
}
