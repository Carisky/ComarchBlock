using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class TrwaleAinag
{
    public int SrTainSrTainid { get; set; }

    public byte SrTainBufor { get; set; }

    public int? SrTainDdfId { get; set; }

    public int SrTainNumerNr { get; set; }

    public string SrTainNumerString { get; set; } = null!;

    public string? SrTainNumerPelny { get; set; }

    public DateTime SrTainDataDok { get; set; }

    public int? SrTainKatId { get; set; }

    public string SrTainKategoria { get; set; } = null!;

    public string SrTainOpis { get; set; } = null!;

    public int? SrTainOpeZalId { get; set; }

    public int? SrTainStaZalId { get; set; }

    public DateTime SrTainTsZal { get; set; }

    public int? SrTainOpeModId { get; set; }

    public int? SrTainStaModId { get; set; }

    public DateTime SrTainTsMod { get; set; }

    public string SrTainOpeModKod { get; set; } = null!;

    public string SrTainOpeModNazwisko { get; set; } = null!;

    public string SrTainOpeZalKod { get; set; } = null!;

    public string SrTainOpeZalNazwisko { get; set; } = null!;

    public virtual DokDefinicje? SrTainDdf { get; set; }

    public virtual Kategorie? SrTainKat { get; set; }

    public virtual ICollection<TrwaleAielem> TrwaleAielems { get; set; } = new List<TrwaleAielem>();
}
