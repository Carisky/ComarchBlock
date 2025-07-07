using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class SzDekNag
{
    public int SzDSzDid { get; set; }

    public short SzDTyp { get; set; }

    public int SzDPodTyp { get; set; }

    public string SzDSymbol { get; set; } = null!;

    public string SzDNazwa { get; set; } = null!;

    public byte SzDNieAktywny { get; set; }

    public int? SzDOpeZalId { get; set; }

    public int? SzDStaZalId { get; set; }

    public DateTime SzDTsZal { get; set; }

    public int? SzDOpeModId { get; set; }

    public int? SzDStaModId { get; set; }

    public DateTime SzDTsMod { get; set; }

    public string SzDOpeModKod { get; set; } = null!;

    public string SzDOpeModNazwisko { get; set; } = null!;

    public string SzDOpeZalKod { get; set; } = null!;

    public string SzDOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<SzDekElem> SzDekElems { get; set; } = new List<SzDekElem>();
}
