using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DokumentyDostawyHistorium
{
    public int DdhDdhid { get; set; }

    public int DdhDdnid { get; set; }

    public string DdhKorelacja { get; set; } = null!;

    public string DdhCheckSum { get; set; } = null!;

    public DateTime DdhModificationDate { get; set; }

    public string DdhDdtyp { get; set; } = null!;

    public int DdhRodzaj { get; set; }

    public int DdhStatus { get; set; }

    public DateTime DdhDataOperacji { get; set; }

    public string DdhPlik { get; set; } = null!;

    public string DdhOpis { get; set; } = null!;

    public int? DdhOpeId { get; set; }

    public string DdhOpeKod { get; set; } = null!;

    public string DdhOpeNazwisko { get; set; } = null!;

    public virtual DokumentyDostawyNag DdhDdn { get; set; } = null!;
}
