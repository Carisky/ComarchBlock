using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class PodArkuszInwenNag
{
    public int PaiPaiid { get; set; }

    public int PaiTrNid { get; set; }

    public int PaiNumerNr { get; set; }

    public short PaiStatus { get; set; }

    public string PaiOpis { get; set; } = null!;

    public string PaiAinumerPelny { get; set; } = null!;

    public int? PaiOpeZalId { get; set; }

    public int? PaiStaZalId { get; set; }

    public DateTime PaiTsZal { get; set; }

    public int? PaiOpeModId { get; set; }

    public int? PaiStaModId { get; set; }

    public DateTime PaiTsMod { get; set; }

    public string PaiOpeModKod { get; set; } = null!;

    public string PaiOpeModNazwisko { get; set; } = null!;

    public string PaiOpeZalKod { get; set; } = null!;

    public string PaiOpeZalNazwisko { get; set; } = null!;

    public virtual TraNag PaiTrN { get; set; } = null!;

    public virtual ICollection<PodArkuszInwenElem> PodArkuszInwenElems { get; set; } = new List<PodArkuszInwenElem>();
}
