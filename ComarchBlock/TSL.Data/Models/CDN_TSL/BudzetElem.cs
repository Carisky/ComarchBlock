using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class BudzetElem
{
    public int BuEBuEid { get; set; }

    public int BuEBuNid { get; set; }

    public int BuEMiesiac { get; set; }

    public decimal BuEKwota { get; set; }

    public decimal BuEKwotaPoprzednia { get; set; }

    public int? BuEOpeZalId { get; set; }

    public int? BuEStaZalId { get; set; }

    public DateTime BuETsZal { get; set; }

    public int? BuEOpeModId { get; set; }

    public int? BuEStaModId { get; set; }

    public DateTime BuETsMod { get; set; }

    public string BuEOpeModKod { get; set; } = null!;

    public string BuEOpeModNazwisko { get; set; } = null!;

    public string BuEOpeZalKod { get; set; } = null!;

    public string BuEOpeZalNazwisko { get; set; } = null!;

    public virtual BudzetNag BuEBuN { get; set; } = null!;
}
