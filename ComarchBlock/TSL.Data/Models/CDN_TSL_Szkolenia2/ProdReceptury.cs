using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class ProdReceptury
{
    public int PdRPdRid { get; set; }

    public int? PdRTwrId { get; set; }

    public string PdRKod { get; set; } = null!;

    public string PdRNazwa { get; set; } = null!;

    public byte PdRDomyslna { get; set; }

    public decimal PdRIlosc { get; set; }

    public string PdRJm { get; set; } = null!;

    public string PdROpis { get; set; } = null!;

    public int? PdROpeZalId { get; set; }

    public int? PdRStaZalId { get; set; }

    public DateTime PdRTsZal { get; set; }

    public int? PdROpeModId { get; set; }

    public int? PdRStaModId { get; set; }

    public DateTime PdRTsMod { get; set; }

    public string PdROpeModKod { get; set; } = null!;

    public string PdROpeModNazwisko { get; set; } = null!;

    public string PdROpeZalKod { get; set; } = null!;

    public string PdROpeZalNazwisko { get; set; } = null!;

    public virtual Towary? PdRTwr { get; set; }

    public virtual ICollection<ProdSkladniki> ProdSkladnikis { get; set; } = new List<ProdSkladniki>();
}
