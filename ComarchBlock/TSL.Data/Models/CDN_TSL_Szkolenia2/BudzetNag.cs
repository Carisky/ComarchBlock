using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class BudzetNag
{
    public int BuNBuNid { get; set; }

    public int BuNAccId { get; set; }

    public decimal BuNKwota { get; set; }

    public decimal BuNKwotaPoprzednia { get; set; }

    public DateTime BuNDataDok { get; set; }

    public string BuNOpis { get; set; } = null!;

    public byte BuNBufor { get; set; }

    public int BuNKorekta { get; set; }

    public byte BuNFinalny { get; set; }

    public int? BuNOpeZalId { get; set; }

    public int? BuNStaZalId { get; set; }

    public DateTime BuNTsZal { get; set; }

    public int? BuNOpeModId { get; set; }

    public int? BuNStaModId { get; set; }

    public DateTime BuNTsMod { get; set; }

    public string BuNOpeModKod { get; set; } = null!;

    public string BuNOpeModNazwisko { get; set; } = null!;

    public string BuNOpeZalKod { get; set; } = null!;

    public string BuNOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<BudzetElem> BudzetElems { get; set; } = new List<BudzetElem>();
}
