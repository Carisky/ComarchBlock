using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class KragKosztNag
{
    public int KknKknid { get; set; }

    public int KknOobId { get; set; }

    public string KknSymbol { get; set; } = null!;

    public int? KknAccId { get; set; }

    public short KknNieAktywny { get; set; }

    public int? KknOpeZalId { get; set; }

    public int? KknStaZalId { get; set; }

    public DateTime KknTsZal { get; set; }

    public int? KknOpeModId { get; set; }

    public int? KknStaModId { get; set; }

    public DateTime KknTsMod { get; set; }

    public string KknOpeModKod { get; set; } = null!;

    public string KknOpeModNazwisko { get; set; } = null!;

    public string KknOpeZalKod { get; set; } = null!;

    public string KknOpeZalNazwisko { get; set; } = null!;

    public virtual Kontum? KknAcc { get; set; }

    public virtual OkresyObrach KknOob { get; set; } = null!;

    public virtual ICollection<KragKosztElem> KragKosztElems { get; set; } = new List<KragKosztElem>();
}
