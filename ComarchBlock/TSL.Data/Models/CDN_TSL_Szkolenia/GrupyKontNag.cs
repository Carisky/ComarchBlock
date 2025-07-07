using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class GrupyKontNag
{
    public int GknGknid { get; set; }

    public int? GknOobId { get; set; }

    public string GknSymbol { get; set; } = null!;

    public byte? GknNieAktywny { get; set; }

    public int? GknOpeZalId { get; set; }

    public int? GknStaZalId { get; set; }

    public DateTime GknTsZal { get; set; }

    public int? GknOpeModId { get; set; }

    public int? GknStaModId { get; set; }

    public DateTime GknTsMod { get; set; }

    public string GknOpeModKod { get; set; } = null!;

    public string GknOpeModNazwisko { get; set; } = null!;

    public string GknOpeZalKod { get; set; } = null!;

    public string GknOpeZalNazwisko { get; set; } = null!;

    public virtual OkresyObrach? GknOob { get; set; }

    public virtual ICollection<GrupyKontElem> GrupyKontElems { get; set; } = new List<GrupyKontElem>();
}
